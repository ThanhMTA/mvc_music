using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class NewNotableController : Controller
    {
        // GET: NewNotable
        public ActionResult Notable()
        {
            return View();
        }
    }
}