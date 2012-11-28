using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiagnosticsDemo.v2.Controllers
{
    using System.Diagnostics;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Diagnostics Demo v2.0";

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(string button)
        {
            switch (button)
            {
                case "tracebutton":
                    System.Diagnostics.Trace.TraceError("Something bad just happened - error trace.");
                    break;

                case "windowslogbutton":
                    EventLog.WriteEntry("FooSource", "Something bad just happened - Windows log", EventLogEntryType.Error);
                    break;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
