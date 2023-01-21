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
    }
}