namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Phongban : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhongBans",
                c => new
                    {
                        Ma_phongban = c.String(nullable: false, maxLength: 128),
                        Ten_phongban = c.String(),
                    })
                .PrimaryKey(t => t.Ma_phongban);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhongBans");
        }
    }
}
