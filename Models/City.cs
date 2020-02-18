namespace NoAutocar.Models
{
    /// <summary>
    /// This struct represents a city
    /// </summary>
    public struct City
    {
        #region Public Properties
        /// <summary>
        /// The displayed Name of the <see cref="City"/>
        /// </summary>
        public string Name { get; private set; }
        #endregion

        #region Constructors
        public City(string name)
        {
            Name = name;
        }
        #endregion

        #region Operators
        public static bool operator ==(City city1, City city2)
        {
            return city1.Name == city2.Name;
        }

        public static bool operator ==(City city1, string cityName)
        {
            return city1.Name == cityName;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator !=(City city1, string cityName)
        {
            return !(city1 == cityName);
        }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
