namespace MVC_Web_Proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorilers",
                c => new
                    {
                        kategoriID = c.Int(nullable: false, identity: true),
                        kategoriAdı = c.String(),
                    })
                .PrimaryKey(t => t.kategoriID);
            
            CreateTable(
                "dbo.Musterilers",
                c => new
                    {
                        musteriID = c.Int(nullable: false, identity: true),
                        musteriAdı = c.String(),
                        musteriSoyadı = c.String(),
                    })
                .PrimaryKey(t => t.musteriID);
            
            CreateTable(
                "dbo.Satıslar",
                c => new
                    {
                        satisID = c.Int(nullable: false, identity: true),
                        fiyat = c.Int(nullable: false),
                        adet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.satisID);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        urunID = c.Int(nullable: false, identity: true),
                        urunAdı = c.String(),
                        urunKategori = c.String(),
                        urunFiyat = c.String(),
                    })
                .PrimaryKey(t => t.urunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
            DropTable("dbo.Satıslar");
            DropTable("dbo.Musterilers");
            DropTable("dbo.Kategorilers");
        }
    }
}
