using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoAutocar.Controllers;
using NoAutocar.Models;
using System.Threading;

namespace NoAutocar.Views
{
    public partial class FindTab : Form, ITabable
    {
        bool interactable = true;

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
        public Journey[] Results { get; private set; }

        public FindTab()
        {
            InitializeComponent();
            ReloadAutocompletes();
            Interactable = true;
            DatabaseController.OnUpdate += OnDatabaseUpdate;
            findBW.ProgressChanged += new ProgressChangedEventHandler(FindBW_ProgressChanged);
            findBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(FindBW_RunWorkerCompleted);
        }

        public Form Form => this;

        public string TabName => "Trouver itinéraire";

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
            Results = null;
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
                        if (cities.FirstOrDefault() == line.End)
                            cities = cities.Reverse();
                        Journey journey = new Journey(finalTime, finalCost, cities.ToArray());
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
            foreach (Journey journey in Results)
            {
                Console.WriteLine(string.Join(",", journey.Cities.Select(c => c.ToString()).ToArray()));
            }
            Interactable = true;
        }
    }
}
