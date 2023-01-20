using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Web_Proje.Models.classes
{
    public class Satıslar
    {
        [Key]
        public int satisID { get; set; }

        public int fiyat { get; set; }

        public int adet { get; set; }

        public int? urunID { get; set; }
        public Urunler Urunler { get; set; }

        public int? musteriID { get; set; }
        public Musteriler Musteriler { get; set; }
    }
}