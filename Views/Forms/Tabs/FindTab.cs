using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NoAutocar.Controllers;
using NoAutocar.Models;
using NoAutocar.Views.Components;

namespace NoAutocar.Views
{
    /// <summary>
    /// This <see cref=" System.Windows.Forms.Form"/> provides a way to request <see cref="Journey"/>s
    /// </summary>
    public partial class FindTab : Form, ITabable
    {
        #region Private Fields
        bool interactable = true;
        Journey[] results;
        #endregion

        #region Public Properties
        /// <summary>
        /// Use this property to switch journey request inputs to read only
        /// </summary>
        public bool Interactable
        {
            get => interactable;
            set
            {
                interactable = value;
                fromInput.ReadOnly = !interactable;
                toInput.ReadOnly = !interactable;
                maxCostInput.ReadOnly = !interactable;
                maxTimeInput.ReadOnly = !interactable;
                confirmButton.Text = interactable ? "Go!" : "Cancel";
            }
        }

        /// <summary>
        /// Contains the results of the last request
        /// </summary>
        public Journey[] Results {
            get => results;
            private set {
                //TODO : add a sort dropdown to form
                results = value.OrderBy(r => r.Cost).ThenBy(r => r.Duration).ToArray();

                RefreshResultsDisplay();
            }
        }

        public Form Form => this;

        public string TabName => "Trouver itinéraire";
        #endregion

        #region Constructors
        public FindTab()
        {
            InitializeComponent();
            ReloadAutocompletes();
            Interactable = true;
            DatabaseController.OnUpdate += OnDatabaseUpdate;
            findBW.ProgressChanged += new ProgressChangedEventHandler(FindBW_ProgressChanged);
            findBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FindBW_RunWorkerCompleted);
        }
        #endregion

        #region Public Methods
        public override void Refresh()
        {
            base.Refresh();
            RefreshResultsDisplay();
        }
        #endregion

        #region Private Methods
        void ReloadAutocompletes()
        {
            fromInput.AutoCompleteCustomSource = DatabaseController.CityAutocomplete;
            toInput.AutoCompleteCustomSource = DatabaseController.CityAutocomplete;
        }

        void OnDatabaseUpdate(object sender, EventArgs e)
        {
            ReloadAutocompletes();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Interactable)
            {
                Interactable = false;
                findBW.RunWorkerAsync();
            }
            else
            {
                findBW.CancelAsync();
            }
        }

        private void FindBW_DoWork(object sender, DoWorkEventArgs e)
        {
            results = new Journey[0];
            List<Line> lines = DatabaseController.Datas
                .Where(d =>
                    (d.Start == fromInput.Text || (!d.OneWay && d.End == fromInput.Text))
                    && (d.End == toInput.Text || (!d.OneWay && d.Start == toInput.Text))
                )
                .ToList();

            List<Journey> journeys = new List<Journey>();
            findBW.ReportProgress(journeys.Count);

            foreach (Line line in lines)
            {
                for (int i = 0; i < Math.Pow(2, line.Steps.Count); i++)
                {
                    if (findBW.CancellationPending)
                    {
                        resultsBox.Text = string.Format("Recherche annulée : {0} résultat{1}", Results.Length, Results.Length > 0 ? "s" : "");
                        Results = journeys.ToArray();
                        Interactable = true;
                        return;
                    }

                    char[] b = Convert.ToString(i, 2).Reverse().ToArray();
                    List<Step> steps = new List<Step>();
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (b[j] == '1') steps.Add(line.Steps[j]);
                    }

                    float finalCost = line.BaseCost + steps.Sum(step => step.CostModification);
                    int finalTime = line.BaseTime + steps.Sum(step => step.TimeModification);
                    if (finalCost <= (float)maxCostInput.Value && finalTime <= maxTimeInput.Value)
                    {
                        var cities = steps.Select(s => s.City).Prepend(line.Start).Append(line.End);
                        if (line.End == fromInput.Text)
                            cities = cities.Reverse();
                        Journey journey = new Journey(line, finalTime, finalCost, cities.ToArray());
                        journeys.Add(journey);
                        findBW.ReportProgress(journeys.Count);
                    }
                }
            }

            Results = journeys.ToArray();
        }

        private void FindBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultsBox.Text = string.Format("Recherche en cours : {0} trajets trouvés", e.ProgressPercentage);
        }

        private void FindBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resultsBox.Text = string.Format("Recherche terminée : {0} résultat{1}", Results.Length, Results.Length > 0 ? "s" : "");
            Refresh();
            Interactable = true;
        }

        void RefreshResultsDisplay()
        {
            if (Results == null) return;

            for (int i = 0; i < Results.Length; i++)
            {
                JourneyDisplay journeyDisplay = new JourneyDisplay(Results[i]);
                journeyDisplay.Location = new Point(resultsPanel.Margin.Left, i * journeyDisplay.Size.Height);
                resultsPanel.Controls.Add(journeyDisplay);
            }
        }
        #endregion
    }
}
