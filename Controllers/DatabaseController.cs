using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoAutocar.Models;

namespace NoAutocar.Controllers
{
    /// <summary>
    /// This <see cref="StaticController{DatabaseController}"/> is a simplified database system that stores <see cref="Line"/>s
    /// </summary>
    class DatabaseController : StaticController<DatabaseController>
    {
        #region Private Fields
        List<Line> datas;
        AutoCompleteStringCollection cityAutocomplete;
        #endregion

        #region Static Properties
        /// <summary>
        /// Every <see cref="Line"/>s stored in database
        /// </summary>
        public static Line[] Datas => Instance.datas.ToArray();

        /// <summary>
        /// An <see cref="AutoCompleteStringCollection"/> filled with every <see cref="City"/> found in database
        /// </summary>
        public static AutoCompleteStringCollection CityAutocomplete => Instance.cityAutocomplete;
        #endregion

        #region Events
        /// <summary>
        /// This event is called every time database updates
        /// </summary>
        public static event EventHandler OnUpdate;
        #endregion

        #region Constructors
        public DatabaseController() : base(true)
        {
            LoadDatabase();
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Returns every distinct <see cref="City"/> in database
        /// </summary>
        /// <returns>An array of <see cref="City"/></returns>
        public static City[] GetAllCities()
        {
            return Instance.datas
                .SelectMany(j => j.Steps.Select(s => s.City).Append(j.Start).Append(j.End))
                .Distinct()
                .ToArray();
        }

        /// <summary>
        /// Adds a <see cref="Line"/> to the database
        /// </summary>
        /// <param name="line">The <see cref="Line"/> to add</param>
        public static void Insert(Line line)
        {
            if (Instance.datas.Any(l => l.Name == line.Name))
                throw new Exception(string.Format("Insert failed : A line named {0} already exists in database", line.Name));

            Instance.datas.Add(line);

            Instance.UpdateDatabase();
        }

        /// <summary>
        /// Modifies a <see cref="Line"/> stored in database
        /// </summary>
        /// <param name="line">The <see cref="Line"/> to update</param>
        public static void Update(Line line)
        {
            Line oldLine = Instance.datas.Where(l => l.Name == line.Name).FirstOrDefault();
            if (oldLine == null)
                throw new Exception(string.Format("Update failed : No line named {0} found in database", line.Name));

            Instance.datas[Instance.datas.IndexOf(oldLine)] = line;

            Instance.UpdateDatabase();
        }

        /// <summary>
        /// Deletes a <see cref="Line"/> stored in database
        /// </summary>
        /// <param name="line">The <see cref="Line"/> to delete</param>
        public static void Delete(Line line)
        {
            Line toDelete = Instance.datas.Where(l => l.Name == line.Name).FirstOrDefault();
            if (toDelete == null)
                throw new Exception(string.Format("Deletion failed : No line named {0} found in database", line.Name));

            Instance.datas.Remove(line);

            Instance.UpdateDatabase();
        }
        #endregion

        #region Private Methods
        void LoadDatabase()
        {
            datas = new List<Line>();

            //TEMP : Fill with default values
            datas.Add(new Line("Test Line", "Lille", "Paris", 180, 10, new Step("Arras"), new Step("Compiègne")));

            UpdateDatabase();
        }

        void UpdateDatabase()
        {
            cityAutocomplete = new AutoCompleteStringCollection();
            cityAutocomplete.AddRange(GetAllCities().Select(c => c.Name).ToArray());

            OnUpdate?.Invoke(this, null);
        }
        #endregion
    }
}
