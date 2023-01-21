using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Web_Proje.Models.classes
{
    public class Urunler
    {
        [Key]
        public int urunID { get; set; }

        public string urunAdı { get; set; }

        public string urunMarka { get; set; }

        public string urunFiyat { get; set; }

        public int stok { get; set; }


        //İlişki
        public int? kategoriID { get; set; }
        public Kategoriler Kategoriler { get; set; }

        public List<Satıslar> satıslars { get; set; }

    }
}