using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Web_Proje.Models.classes
{
    public class Kategoriler
    {
        [Key]
        public int kategoriID { get; set; }

        public string kategoriAdı { get; set; }

        //İlişki
        public List<Urunler> urunlers { get; set; }
    }
}