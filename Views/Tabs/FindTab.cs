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

namespace NoAutocar.Views
{
    public partial class FindTab : Form, ITabable
    {
        public FindTab()
        {
            InitializeComponent();
            ReloadAutocompletes();
        }

        public Form Form => this;

        public string TabName => "Trouver itinéraire";

        void ReloadAutocompletes() {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(DatabaseController.GetAllCities().Select(c => c.Name).ToArray());

            fromInput.AutoCompleteCustomSource = autoComplete;
            toInput.AutoCompleteCustomSource = autoComplete;
        }

        private void FromInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindTab_Load(object sender, EventArgs e)
        {
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
