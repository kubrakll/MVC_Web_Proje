using MVC_Web_Proje.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Proje.Controllers
{
    public class UrunController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var c = db.urunlers.ToList();
            return View(c);
        }

        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler = (from i in db.kategorilers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.kategoriAdı,
                                                 Value = i.kategoriID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult YeniUrun(Urunler u)
        {
            var ktg = db.kategorilers.Where(m => m.kategoriID == u.kategoriID).FirstOrDefault();
            u.Kategoriler = ktg;
            db.urunlers.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var urn = db.urunlers.Find(id);
            db.urunlers.Remove(urn);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}