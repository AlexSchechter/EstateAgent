using EstateAgent.Website.Models;
using Estates.Business;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EstateAgent.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new EstateModel();
            model.Estates = new List<Estate>();
            model.Estates.Add(new Estate(3, 2, 1000, "W12 3RT", 1));
            model.Estates.Add(new Estate(10, 8, 10000, "CT4 1BY", 2));
            return View("MainPage", model);
        }
    }
}