using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoAutocar.Models
{
    public class Journey
    {
        public City[] Cities { get; private set; }
        public int Duration { get; private set; }
        public float Cost { get; private set; }

        public Journey(int duration, float cost, params City[] cities)
        {
            Cities = cities;
            Duration = duration;
            Cost = cost;
        }
    }
}
