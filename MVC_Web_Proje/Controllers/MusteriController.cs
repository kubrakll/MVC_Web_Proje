using MVC_Web_Proje.Models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Proje.Controllers
{
    public class MusteriController : Controller
    {
        Context db = new Context();

        public ActionResult Index(string p)
        {
            var degerler = from d in db.musterilers select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(x => x.musteriAdı.Contains(p));
            }
            return View(degerler.ToList());
            //var c = db.musterilers.ToList();
            //return View(c);
        }

        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMusteri(Musteriler m)
        {
            db.musterilers.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var mst = db.musterilers.Find(id);
            db.musterilers.Remove(mst);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult MusteriGetir(int id)
        {
            var mus = db.musterilers.Find(id);
            return View("MusteriGetir", mus);
        }
        [HttpPost]
        public ActionResult Güncelle(Musteriler m)
        {
            var mus = db.musterilers.Find(m.musteriID);
            mus.musteriAdı = m.musteriAdı;
            mus.musteriSoyadı = m.musteriSoyadı;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}