namespace MVC_Web_Proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddclassas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunlers", "urunMarka", c => c.String());
            DropColumn("dbo.Urunlers", "urunKategori");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunlers", "urunKategori", c => c.String());
            DropColumn("dbo.Urunlers", "urunMarka");
        }
    }
}
