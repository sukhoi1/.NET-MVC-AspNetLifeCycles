using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNetLifeCycles.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Placeholder", "Placeholder");
            return View("~/Views/Shared/Many.cshtml", (object)data);
        }
    }
}