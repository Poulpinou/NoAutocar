using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoAutocar.Models;
using NoAutocar.Controllers;

namespace NoAutocar.Views.Components
{
    /// <summary>
    /// Use this <see cref="Control"/> to create or edit a <see cref="Models.Step"/>
    /// </summary>
    public partial class StepInput : UserControl
    {
        #region Private Fields
        Step step;
        #endregion

        #region Public Properties
        /// <summary>
        /// The currently edited <see cref="Models.Step"/>
        /// </summary>
        public Step Step {
            get => step;
            set {
                step = value;
                RefreshDisplay();
            }
        }
        #endregion

        #region Constructors
        public StepInput()
        {
            InitializeComponent();

            cityInput.AutoCompleteCustomSource = DatabaseController.CityAutocomplete;
        }

        public StepInput(Step step) : this()
        {
            Step = step;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Binds the fields to the <see cref="Step"/>
        /// </summary>
        public void RefreshDisplay()
        {
            cityInput.Text = step.City.Name;
            timeInput.Value = step.TimeModification;
            costInput.Value = (decimal)step.CostModification;
        }
        #endregion

        #region Private Methods
        private void CityInput_TextChanged(object sender, EventArgs e)
        {
            step.City = new City(cityInput.Text);
        }

        private void TimeInput_ValueChanged(object sender, EventArgs e)
        {
            step.TimeModification = (int)Math.Round(timeInput.Value);
        }

        private void CostInput_ValueChanged(object sender, EventArgs e)
        {
            step.CostModification = (float)costInput.Value;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
        #endregion
    }
}
