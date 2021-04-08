namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_ChuyenPhong : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuyenPhongs",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        Ma_phongban = c.String(),
                        NgayChuyen = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChuyenPhongs");
        }
    }
}
