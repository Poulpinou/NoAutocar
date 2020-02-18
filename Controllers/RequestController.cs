using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NoAutocar.Models;

namespace NoAutocar.Controllers
{
    public class RequestController : StaticController<RequestController>
    {

        public bool IsReady { get; private set; }

        public Request CurrentRequest { get; private set; }

        public RequestController() : base(false)
        {
            IsReady = true;
        }

        public static void SendRequest(Request request)
        {
            if (!Instance.IsReady)
            {
                throw new Exception("Can't send request, Controller is already processing a request"); 
            }

            Instance.CurrentRequest = request;
            Thread thread = new Thread(new ThreadStart(Instance.RunRequest));
            
            Instance.IsReady = false;
            thread.Start();
        }

        void RunRequest()
        {
            List<Journey> journeys = DatabaseController.Datas
                .Where(d =>
                    (d.Start == CurrentRequest.start || (!d.OneWay && d.End == CurrentRequest.start))
                    && (d.End == CurrentRequest.end || (!d.OneWay && d.Start == CurrentRequest.end))
                )
                .ToList();
        }
    }
}
