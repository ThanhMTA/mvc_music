using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class FavoriteSongController : Controller
    {
        // GET: FavoriteSong
        public ActionResult FavoriteSong()
        {
            return View();
        }
    }
}