using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Main()
        {
            Model1 db = new Model1();
            List<SAN_PHAM> kq = db.SAN_PHAM.ToList();
            ViewBag.count = kq.Count;
            return View(kq);
           

        }
        public ActionResult index()
        {
            var list = new List<SAN_PHAM>();
            ViewBag.list = list;
            ViewBag.count = list.Count;
            return View(list);
        }
    }
}