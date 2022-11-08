using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class CalenderController : Controller
    {
        // GET: Calender
        public ActionResult Calender()
        {
            return View();
        }
        public ActionResult Calendar_NewRealese()
        {
            return View();
        }
    }
}