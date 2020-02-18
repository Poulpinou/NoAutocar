using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoAutocar.Models
{
    public struct Request
    {
        public readonly City start;
        public readonly City end;
        public readonly int maxTime;
        public readonly float maxCost;

        public Request(City start, City end, int maxTime, float maxCost)
        {
            this.start = start;
            this.end = end;
            this.maxTime = maxTime;
            this.maxCost = maxCost;
        }

        public Request(string start, string end, int maxTime, float maxCost) : this(new City(start), new City(end), maxTime, maxCost) { }
    }
}
