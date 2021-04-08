namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_DuAn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DuAns",
                c => new
                    {
                        MaDuAN = c.Int(nullable: false, identity: true),
                        TenDuAn = c.String(),
                        NgayBatDau = c.String(),
                        NgayKetThuc = c.String(),
                        SoLuong = c.String(),
                        DonGia = c.String(),
                        ChietKhau = c.String(),
                    })
                .PrimaryKey(t => t.MaDuAN);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DuAns");
        }
    }
}
