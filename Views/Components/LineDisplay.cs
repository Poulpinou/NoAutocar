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
    /// This component is used to display a <see cref="Models.Line"/>
    /// </summary>
    public partial class LineDisplay : UserControl
    {
        #region Private fields
        Line line;
        #endregion

        #region Public Properties
        /// <summary>
        /// The <see cref="Models.Line"/> displayed by this <see cref="Control"/> 
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
        public LineDisplay()
        {
            InitializeComponent();
        }

        public LineDisplay(Line line) : this()
        {
            Line = line;
        }
        #endregion

        #region Public Methods
        public override void Refresh()
        {
            base.Refresh();

            lineNameLabel.Text = Line.Name;
            //startCityLabel.Text = Line.Start.Name;
            //endCityLabel.Text = Line.End.Name;
            durationLabel.Text = Line.BaseTime.ToString("0 min");
            costLabel.Text = Line.BaseCost.ToString("0.00 €");
            oneWayLabel.Text = Line.OneWay ? "Oui" : "Non";
        }
        #endregion

        #region Private Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Line == null)
                return;

            Graphics graphics = e.Graphics;
            int radius = 6;
            Pen pen = new Pen(Line.Color, radius);
            Font font = stepsContainer.Font;
            Brush brush = Brushes.Black;
            int distance = (stepsContainer.Width - stepsContainer.Margin.Left + stepsContainer.Margin.Right) / (Line.Steps.Count + 1);
            int xPos = stepsContainer.Location.X + stepsContainer.Margin.Left;
            int xEndPos = stepsContainer.Location.X + stepsContainer.Size.Width - stepsContainer.Margin.Right;
            int yPos = stepsContainer.Location.Y + stepsContainer.Height - stepsContainer.Margin.Bottom - radius * 2;
            int textYPos = stepsContainer.Location.Y - stepsContainer.Margin.Top;

            graphics.DrawLine(pen, xPos, yPos + radius, xEndPos + radius * 2, yPos + radius);

            graphics.DrawEllipse(pen, xPos, yPos, radius * 2, radius * 2);
            graphics.DrawString(Line.Start.Name, font, brush, xPos, textYPos);
            for (int i = 0; i < Line.Steps.Count; i++)
            {
                graphics.DrawEllipse(pen, xPos + (i + 1) * distance, yPos, 10, 10);
                graphics.DrawString(Line.Steps[i].City.Name, font, brush, xPos + (i + 1) * distance, textYPos);
            }
            graphics.DrawEllipse(pen, xEndPos, yPos, radius * 2, radius * 2);
            graphics.DrawString(Line.End.Name, font, brush, xEndPos - radius * 2, textYPos);
            

            graphics.Dispose();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DatabaseController.Delete(Line);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MainView mainView = Form.ActiveForm as MainView;
            if (mainView != null)
                mainView.AddTab(new LineEditorTab(Line), true);
        }
        #endregion
    }
}
