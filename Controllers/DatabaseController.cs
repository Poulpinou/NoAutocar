using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoAutocar.Models;

namespace NoAutocar.Controllers
{
    class DatabaseController : StaticController<DatabaseController>
    {
        List<Line> datas;
        AutoCompleteStringCollection cityAutocomplete;

        public static Line[] Datas => Instance.datas.ToArray();
        public static AutoCompleteStringCollection CityAutocomplete => Instance.cityAutocomplete;


        public static event EventHandler OnUpdate;

        public DatabaseController() : base(true)
        {
            LoadDatabase();
        }

        void LoadDatabase()
        {
            datas = new List<Line>();

            //TEMP : Fill with default values
            datas.Add(new Line("Lille", "Paris", 180, 10, new Step("Arras"), new Step("Compiègne")));

            UpdateDatabase();
        }

        public static City[] GetAllCities() {
            return Instance.datas
                .SelectMany(j => j.Steps.Select(s => s.City).Append(j.Start).Append(j.End))
                .Distinct()
                .ToArray();
        }

        void UpdateDatabase()
        {
            cityAutocomplete = new AutoCompleteStringCollection();
            cityAutocomplete.AddRange(GetAllCities().Select(c => c.Name).ToArray());

            OnUpdate?.Invoke(this, null);
        }
    }
}
