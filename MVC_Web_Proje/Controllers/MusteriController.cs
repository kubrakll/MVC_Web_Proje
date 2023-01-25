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
        public ActionResult Index()
        {
            var c = db.musterilers.ToList();
            return View(c);
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
    }
}