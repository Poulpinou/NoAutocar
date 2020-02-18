using System.Collections.Generic;
using System.Linq;

namespace NoAutocar.Models
{
    /// <summary>
    /// This class stores the path that the autocar will do.
    /// </summary>
    public class Line
    {
        #region Public Properties
        /// <summary>
        /// The name of the autocar line
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The first city visited by the car
        /// </summary>
        public City Start { get; set; }

        /// <summary>
        /// The last city visited by the car
        /// </summary>
        public City End { get; set; }

        /// <summary>
        /// Every possible <see cref="Step"/> for this path
        /// </summary>
        public List<Step> Steps { get; set; }

        /// <summary>
        /// If true, the car can't go from <see cref="End"/> to <see cref="Start"/>
        /// </summary>
        public bool OneWay { get; set; }

        /// <summary>
        /// The amount of time from <see cref="End"/> to <see cref="Start"/> without any <see cref="Step"/>
        /// </summary>
        public int BaseTime { get; set; }

        /// <summary>
        /// The cost from <see cref="End"/> to <see cref="Start"/> without any <see cref="Step"/>
        /// </summary>
        public float BaseCost { get; set; }
        #endregion

        #region Constructors
        public Line() {
            Steps = new List<Step>();
        }

        public Line(City start, City end, int time, float cost, bool oneWay = false, params Step[] steps) : this()
        {
            Start = start;
            End = end;
            OneWay = oneWay;
            
            Steps.AddRange(steps);
        }

        public Line(City start, City end, int time, float cost, params Step[] steps) : this(start, end, time, cost, false, steps) { }

        public Line(string start, string end, int time, float cost, params Step[] steps) : this(new City(start), new City(end), time, cost, false, steps) { }
        #endregion
    }
}
