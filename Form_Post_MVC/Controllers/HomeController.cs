using Form_Post_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form_Post_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                int personId = person.PersonId;
                string name = person.Name;
                string gender = person.Gender;
                string city = person.City;
            }
            return View();
        }
    }
}