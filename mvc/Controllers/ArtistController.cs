using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Artist()
        {
            return View();
        }
    }
}