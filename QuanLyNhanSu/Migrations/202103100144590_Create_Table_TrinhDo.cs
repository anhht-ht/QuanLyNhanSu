namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TrinhDo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrinhDos",
                c => new
                    {
                        Ma_trinhdo = c.String(nullable: false, maxLength: 128),
                        Ten_trinhdo = c.String(),
                    })
                .PrimaryKey(t => t.Ma_trinhdo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrinhDos");
        }
    }
}
