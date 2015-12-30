using EstateAgent.Website.Models;
using Estates.Business;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace EstateAgent.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new EstateModel();
            model.Estates = EstateRepository.ListEstates().OrderBy(x => x.EstateID).ToList();
            return View("MainPage", model);
        }

        public ActionResult Delete(int id)
        {
            EstateRepository.DeleteEstate(id);
            var model = new EstateModel();
            model.Estates = EstateRepository.ListEstates().OrderBy(x => x.EstateID).ToList();
            return View("MainPage", model);
        }
    }
}