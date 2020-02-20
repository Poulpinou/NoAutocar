using System.Drawing;
using System.Windows.Forms;
using NoAutocar.Models;

namespace NoAutocar.Views.Components
{
    /// <summary>
    /// This component displays a <see cref="Models.Journey"/>
    /// </summary>
    public partial class JourneyDisplay : UserControl
    {
        #region Private Fields
        Journey journey;
        #endregion

        #region Public Properties
        /// <summary>
        /// The currently displayed <see cref="Models.Journey"/>
        /// </summary>
        public Journey Journey
        {
            get => journey;
            set
            {
                journey = value;
                Refresh();
            }
        }
        #endregion

        #region Constructors
        public JourneyDisplay()
        {
            InitializeComponent();
        }

        public JourneyDisplay(Journey journey) : this()
        {
            Journey = journey;
        }
        #endregion

        #region Public Methods
        public override void Refresh()
        {
            nameLabel.Text = Journey.Line.Name;
            costLabel.Text = Journey.Cost + "€";
            timeLabel.Text = Journey.Duration + "min";

            string citiesText = string.Join(" => ", journey.Cities);
            Label label = new Label();
            Size textSize = TextRenderer.MeasureText(citiesText, label.Font);
            label.Size = textSize;
            label.Text = citiesText;
            citiesPanel.Controls.Add(label);
        }
        #endregion
    }
}
