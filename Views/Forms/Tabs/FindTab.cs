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
            DatabaseController.OnUpdate += OnDatabaseUpdate;
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
