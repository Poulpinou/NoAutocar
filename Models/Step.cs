namespace NoAutocar.Models
{
    /// <summary>
    /// This class stores the properties of a step on a <see cref="Line"/>
    /// </summary>
    public class Step
    {
        #region Public Properties
        /// <summary>
        /// The <see cref="City"/> of this <see cref="Step"/>
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// The time modification due to this <see cref="Step"/> (in minutes)
        /// </summary>
        public int TimeModification { get; set; }

        /// <summary>
        /// The cost modification due to this <see cref="Step"/> (in euros)
        /// </summary>
        public float CostModification { get; set; }
        #endregion

        #region Constructors
        public Step() { }

        public Step(City city, int timeModification = 30, float costModification = 2) : this() {
            City = city;
            TimeModification = timeModification;
            CostModification = costModification;
        }

        public Step(string city, int timeModification = 30, float costModification = 2) : this(new City(city), timeModification, costModification) { }
        #endregion
    }
}
