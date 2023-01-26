namespace MVC_Web_Proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddclassasas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunlers", "stok", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunlers", "stok");
        }
    }
}
