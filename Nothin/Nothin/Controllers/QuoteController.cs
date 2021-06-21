using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nothin.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult QuotePage()
        {
            return View();
        }
    }
}