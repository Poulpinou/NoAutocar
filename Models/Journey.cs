using System.Collections.Generic;
using System.Linq;

namespace NoAutocar.Models
{
    /// <summary>
    /// This class stores the path that the autocar will do.
    /// </summary>
    public class Journey
    {
        #region Public Properties
        /// <summary>
        /// The name of the autocar line
        /// </summary>
        public string LineName { get; private set; }

        /// <summary>
        /// The first city visited by the car
        /// </summary>
        public City Start { get; private set; }

        /// <summary>
        /// The last city visited by the car
        /// </summary>
        public City End { get; private set; }

        /// <summary>
        /// Every possible <see cref="Step"/> for this path
        /// </summary>
        public List<Step> Steps { get; private set; }

        /// <summary>
        /// If true, the car can't go from <see cref="End"/> to <see cref="Start"/>
        /// </summary>
        public bool OneWay { get; private set; }

        /// <summary>
        /// The amount of time from <see cref="End"/> to <see cref="Start"/> without any <see cref="Step"/>
        /// </summary>
        public int BaseTime { get; private set; }

        /// <summary>
        /// The cost from <see cref="End"/> to <see cref="Start"/> without any <see cref="Step"/>
        /// </summary>
        public float BaseCost { get; private set; }
        #endregion

        #region Constructors
        public Journey(City start, City end, int time, float cost, bool oneWay = false, params Step[] steps)
        {
            Start = start;
            End = end;
            OneWay = oneWay;
            Steps = new List<Step>();
            Steps.AddRange(steps);
        }

        public Journey(City start, City end, int time, float cost, params Step[] steps) : this(start, end, time, cost, false, steps) { }

        public Journey(string start, string end, int time, float cost, params Step[] steps) : this(new City(start), new City(end), time, cost, false, steps) { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Adds a <see cref="Step"/> to <see cref="Steps"/>
        /// </summary>
        /// <param name="step">The <see cref="Step"/> to add</param>
        public void AddStep(Step step)
        {
            if(!Steps.Any(s => s.City == step.City))
            {
                Steps.Add(step);
            }
        }

        /// <summary>
        /// Adds many <see cref="Step"/>s to <see cref="Steps"/>
        /// </summary>
        /// <param name="steps">Every <see cref="Step"/>s to add</param>
        public void AddSteps(params Step[] steps)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                AddStep(steps[i]);
            }
        }

        /// <summary>
        /// Removes a <see cref="Step"/> from <see cref="Steps"/>
        /// </summary>
        /// <param name="step">The <see cref="Step"/> to remove</param>
        public void RemoveStep(Step step)
        {
            RemoveStep(step.City);
        }

        /// <summary>
        /// Removes all <see cref="Step"/>s from <see cref="Steps"/> which has <see cref="Step.City"/> == <paramref name="city"/>
        /// </summary>
        /// <param name="city">The targeted <see cref="City"/></param>
        public void RemoveStep(City city)
        {
            Steps.RemoveAll(s => s.City == city);
        }
        #endregion
    }
}
