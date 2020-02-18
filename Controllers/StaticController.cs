using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoAutocar.Controllers
{
    public abstract class StaticController<TController> where TController : StaticController<TController>, new()
    {
        public static TController Instance;

        public StaticController(bool force = false) {
            if (Instance != null && !force)
                throw new Exception(string.Format("Failed to initialize {0} : it's already instanciated", typeof(TController)));

            Instance = this as TController;
        }
    }
}
