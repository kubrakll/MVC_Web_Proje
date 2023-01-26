using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Web_Proje.Models.classes;

namespace MVC_Web_Proje.Controllers
{
    public class SatisController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            
            List<SelectListItem> degerler = (from i in db.musterilers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.musteriAdı+i.musteriSoyadı,
                                                 Value = i.musteriID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(Satıslar s)
        {
            var ktg = db.musterilers.Where(m => m.musteriID == s.musteriID).FirstOrDefault();
            s.Musteriler = ktg;
            db.satıslars.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}