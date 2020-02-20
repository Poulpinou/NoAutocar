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
using NoAutocar.Views.Components;

namespace NoAutocar.Views
{
    /// <summary>
    /// This tab displays every recorded <see cref="Line"/>s
    /// </summary>
    public partial class LinesTab : Form, ITabable
    {
        #region Public Properties
        public Form Form => this;

        public string TabName => "Lignes";
        #endregion

        #region Constructors
        public LinesTab()
        {
            InitializeComponent();
            Refresh();
            DatabaseController.OnUpdate += OnDatabaseUpdate;
        }
        #endregion

        #region Public Methods
        public override void Refresh()
        {
            linesList.Controls.Clear();
            foreach (Line line in DatabaseController.Datas)
            {
                LineDisplay lineDisplay = new LineDisplay(line);
                lineDisplay.Location = new Point(10, linesList.Controls.Count * lineDisplay.Size.Height);
                linesList.Controls.Add(lineDisplay);
            }
        }
        #endregion

        #region Private Methods
        void OnDatabaseUpdate(object sender, EventArgs e)
        {
            Refresh();
        }
        #endregion
    }
}
