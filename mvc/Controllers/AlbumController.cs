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
            return View(new ALbum());
        }
        [HttpPost]
        public ActionResult createAlbum(ALbum model)
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
        public ActionResult Delete(string MaAlbum)
        {
            Model1 db = new Model1();
            var ds = (from sp in db.DS_SP
                      where sp.MaAl == MaAlbum
                      select sp).ToList();
            foreach(var i in ds)
            {
                db.DS_SP.Remove(i);
                db.SaveChanges();
            }
            var ab = db.ALbums.Find(MaAlbum);
            db.ALbums.Remove(ab);
            db.SaveChanges();
            return RedirectToAction("Album", "Album");
        }
        public ActionResult listSong(string MaAl)//
        {
            Session["MaAl"] = MaAl;
            Model1 db = new Model1();
            var a = db.ALbums.Find(Session["MaAl"]);

            ViewBag.name = a.TenAlbum.ToString();

            var list = (from item in db.DS_SP
                        where item.MaAl == MaAl
                        select item).ToList();
            return View(list);
        }
        public ActionResult newSong()
        {
            Model1 db = new Model1();
            List<SAN_PHAM> list = db.SAN_PHAM.ToList();
            return View(list);             
         
        }
        public ActionResult AddToAlbum(String MaSP)
        {
            Model1 db = new Model1();
            DS_SP model = new DS_SP();
            model.MaSP = MaSP;
            model.MaAl = (string)Session["MaAL"];
            if (db.DS_SP.Any(x => x.MaSP == model.MaSP))
            {
                ViewBag.thongbao = " this song is readly";
                return RedirectToAction("newSong", "Album");

            }
            else
            {
               
                db.DS_SP.Add(model);
                db.SaveChanges();
                return RedirectToAction("listSong", "Album");
            }
        }
        public ActionResult DeleteSong(string MaSP)
        {
            Model1 db = new Model1();
            //var ab = (from ds in db.DS_SP
            //          where ds.MaAl == Session["MaAl"] && ds.MaSP == MaSP
            //          select ds).FirstOrDefault();
            var sp = db.DS_SP.Find(Session["MaAl"],MaSP);
            db.DS_SP.Remove(sp);
            db.SaveChanges();
            return RedirectToAction("Album", "Album");
        }


    }
}