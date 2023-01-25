using MVC_Web_Proje.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace MVC_Web_Proje.Controllers
{
    public class KategoriController : Controller
    {
        Context db = new Context();
        public ActionResult Index(int sayfa=1)
        {
            // var c = db.kategorilers.ToList();
            var c = db.kategorilers.ToList().ToPagedList(sayfa, 5);
            return View(c);
        }

        [HttpGet] //Sayfa Yüklenince gelen sayfa
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost] //Butona basılınca çalış demek
        public ActionResult YeniKategori(Kategoriler k)
        {
            db.kategorilers.Add(k);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var ktg = db.kategorilers.Find(id);
            db.kategorilers.Remove(ktg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KategoriGetir(int id)
        {
            var ktg = db.kategorilers.Find(id);
            return View("KategoriGetir",ktg);

        }

        [HttpPost]
        public ActionResult Güncelle(Kategoriler p1)
        {
            var ktgr = db.kategorilers.Find(p1.kategoriID);
            ktgr.kategoriID = p1.kategoriID;
            ktgr.kategoriAdı = p1.kategoriAdı;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}