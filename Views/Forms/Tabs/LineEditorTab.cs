using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoAutocar.Views.Components;
using NoAutocar.Models;
using NoAutocar.Controllers;

namespace NoAutocar.Views
{
    /// <summary>
    /// Use this form to create or edit a <see cref="Models.Line"/>
    /// </summary>
    public partial class LineEditorTab : Form, ITabable
    {
        #region Private Fields
        Line line;
        bool isInEditMode;
        #endregion

        #region Public Properties
        /// <summary>
        /// The reference <see cref="System.Windows.Forms.Form"/> for <see cref="ITabable"/>
        /// </summary>
        public Form Form => this;

        /// <summary>
        /// The name to display in the tab
        /// </summary>
        public string TabName { get; private set; }

        /// <summary>
        /// The currently edited <see cref="Models.Line"/>
        /// </summary>
        public Line Line
        {
            get => line;
            set
            {
                line = value;
                Refresh();
            }
        }
        #endregion

        #region Constructors
        public LineEditorTab()
        {
            InitializeComponent();
            TabName = "Créer une ligne";
            confirmButton.Text = "Créer";
            cancelButton.Text = "Réinitialiser";
            isInEditMode = false;
            Line = new Line();
        }

        public LineEditorTab(Line line)
        {
            InitializeComponent();
            TabName = "Editer une ligne";
            confirmButton.Text = "Modifier";
            cancelButton.Text = "Annuler";
            lineNameInput.ReadOnly = true;
            isInEditMode = true;
            Line = line;
        }
        #endregion

        #region Public Methods
        public override void Refresh()
        {
            lineNameInput.Text = Line.Name;
            oneWayInput.Checked = Line.OneWay;
            startCityInput.Text = Line.Start.Name;
            startCityInput.AutoCompleteCustomSource = DatabaseController.CityAutocomplete;
            endCityInput.Text = Line.End.Name;
            endCityInput.AutoCompleteCustomSource = DatabaseController.CityAutocomplete;
            baseTimeInput.Value = Line.BaseTime;
            baseCostInput.Value = (decimal)Line.BaseCost;
            colorButton.BackColor = Line.Color;

            stepsPanel.Controls.Clear();
            foreach (Step step in Line.Steps)
            {
                StepInput stepInput = new StepInput(step);
                stepInput.OnDelete += OnStepInputDelete;
                stepInput.Location = new Point(10, stepsPanel.Controls.Count * stepInput.Size.Height);
                stepsPanel.Controls.Add(stepInput);
            }
        }
        #endregion

        #region Private Method
        private void OnStepInputDelete(object sender, EventArgs e)
        {
            StepInput stepInput = (StepInput)sender;
            if(stepInput != null)
            {
                Line.Steps.Remove(stepInput.Step);
                Refresh();
            }
        }

        private void NewStepButton_Click(object sender, EventArgs e)
        {
            Line.Steps.Add(new Step());
            Refresh();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInEditMode)
                {
                    DatabaseController.Update(Line);
                }
                else
                {
                    DatabaseController.Insert(Line);
                }
                Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        void Cancel()
        {
            if (isInEditMode)
            {
                MainView mainView = Form.ActiveForm as MainView;
                if (mainView != null)
                    mainView.CloseTab(this);
                //Parent.Controls.Remove(this);
            }
            else
            {
                Line = new Line();
            }
        }

        private void LineNameInput_TextChanged(object sender, EventArgs e)
        {
            Line.Name = lineNameInput.Text;
        }

        private void OneWayInput_CheckedChanged(object sender, EventArgs e)
        {
            Line.OneWay = oneWayInput.Checked;
        }

        private void StartCityInput_TextChanged(object sender, EventArgs e)
        {
            Line.Start = new City(startCityInput.Text);
        }

        private void EndCityInput_TextChanged(object sender, EventArgs e)
        {
            Line.End = new City(endCityInput.Text);
        }

        private void BaseTimeInput_ValueChanged(object sender, EventArgs e)
        {
            Line.BaseTime = (int)Math.Round(baseTimeInput.Value);
        }

        private void BaseCostInput_ValueChanged(object sender, EventArgs e)
        {
            Line.BaseCost = (float)baseCostInput.Value;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.Color = Line.Color;

            if (colorDialog.ShowDialog() == DialogResult.OK) { }
                Line.Color = colorDialog.Color;

            Refresh();
        }
        #endregion
    }
}
