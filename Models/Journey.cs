using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoAutocar.Models
{
    /// <summary>
    /// This model holds the datas of a single journey on a <see cref="Models.Line"/>
    /// </summary>
    public struct Journey
    {
        #region Public Properties
        /// <summary>
        /// The <see cref="Models.Line"/> that provides this <see cref="Journey"/>
        /// </summary>
        public Line Line { get; private set; }

        /// <summary>
        /// Every <see cref="City"/> visited by this <see cref="Journey"/>
        /// </summary>
        public City[] Cities { get; private set; }

        /// <summary>
        /// The total duration of the <see cref="Journey"/>(in min)
        /// </summary>
        public int Duration { get; private set; }

        /// <summary>
        /// The total cost of the <see cref="Journey"/>(in €)
        /// </summary>
        public float Cost { get; private set; }
        #endregion

        #region Constructors
        public Journey(Line line, int duration, float cost, params City[] cities)
        {
            Cities = cities;
            Duration = duration;
            Cost = cost;
            Line = line;
        }
        #endregion
    }
}
