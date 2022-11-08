using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;
using System.Data.Entity;

namespace mvc.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Album()

        {
            Model1 db = new Model1();
            List<ALbum> kq = db.ALbums.ToList();
            return View(kq);
        }
        public ActionResult createAlbum()
        {
            return View(new ALbum() );
        }
        [HttpPost]
        public ActionResult createAlbum( ALbum model)
        {
            Model1 db = new Model1();
            if (db.ALbums.Any(x => x.TenAlbum == model.TenAlbum))
            {
                ViewBag.thongbao = " this album is readly. Create new album!";
                return View();
            }
            else
            {
                db.ALbums.Add(model);
                db.SaveChanges();
                Session["name"] = model.MaAl.ToString();
                return RedirectToAction("Album", "Album");
            }
            
        }
        public ActionResult Delete( string MaAlbum)
        {
            Model1 db = new Model1();
            var ab = db.ALbums.Find(MaAlbum);
            db.ALbums.Remove(ab);
            db.SaveChanges();
            return RedirectToAction("Album","Album");
        }
    }
}