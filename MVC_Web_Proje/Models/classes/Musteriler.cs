using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Web_Proje.Models.classes
{
    public class Musteriler
    {
        [Key]
        public int musteriID { get; set; }

        public string musteriAdı { get; set; }

        public string musteriSoyadı { get; set; }
    }
}