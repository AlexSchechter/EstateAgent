using EstateAgent.Website.Models;
using Estates.Business;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Collections;

namespace EstateAgent.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private EstateModel CreateEstateModel ()
        {     
                var model = new EstateModel();
                model.Estates = EstateRepository.ListEstates().OrderBy(x => x.EstateID).ToList();
                return model;
        }

        public ActionResult Index()
        {
            return View("MainPage", CreateEstateModel());
        }

        public ActionResult Delete(int id)
        {
            EstateRepository.DeleteEstate(id);
            return View("MainPage", CreateEstateModel());
        }

        public ActionResult Add(string postcode, int bathrooms, int bedrooms, int squareFoot)
        {            
            EstateRepository.SaveEstate(bedrooms, bathrooms, postcode, squareFoot);
            return View("MainPage", CreateEstateModel());
        }

        public ActionResult Create()
        {
            return View("AddEstate");
        }
    }
}