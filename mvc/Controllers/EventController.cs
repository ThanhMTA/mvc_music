using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Event()
        {
            return View();
        }
    }
}