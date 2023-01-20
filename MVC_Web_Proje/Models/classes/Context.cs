using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Web_Proje.Models.classes
{
    public class Context:DbContext
    {
        public DbSet<Kategoriler> kategorilers { get; set; }

        public DbSet<Musteriler> musterilers { get; set; }

        public DbSet<Satıslar> satıslars { get; set; }

        public DbSet<Urunler> urunlers { get; set; }
    }
}