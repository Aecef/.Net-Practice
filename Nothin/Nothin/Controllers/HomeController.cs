using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nothin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Full(string id)
        {
            ViewBag.word = id;
            return View();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Notes");
            //return View();
        }

        public ActionResult Notes()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Component()
        {

            return View();
        }
        public ActionResult Formuse()
        {

            return View();
        }

        public ActionResult Students()
        {
            return View();
        }
    }
}