using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoAutocar.Models;

namespace NoAutocar.Controllers
{
    class DatabaseController : StaticController<DatabaseController>
    {
        List<Journey> datas;

        public static Journey[] Datas => Instance.datas.ToArray();

        public DatabaseController() : base(true)
        {
            LoadDatabase();
        }

        void LoadDatabase()
        {
            datas = new List<Journey>();

            //TEMP : Fill with default values
            datas.Add(new Journey("Lille", "Paris", 180, 10, new Step("Arras"), new Step("Compiègne")));
        }

        public static City[] GetAllCities() {
            return Instance.datas
                .SelectMany(j => j.Steps.Select(s => s.City).Append(j.Start).Append(j.End))
                .Distinct()
                .ToArray();
        }
    }
}
