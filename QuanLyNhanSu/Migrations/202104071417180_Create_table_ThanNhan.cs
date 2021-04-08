namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_ThanNhan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ThanNhans", "Moiquanhe", c => c.String());
            AddColumn("dbo.ThanNhans", "HoTen", c => c.String());
            AddColumn("dbo.ThanNhans", "Noidung", c => c.String());
            DropColumn("dbo.ThanNhans", "MaNghiViec");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ThanNhans", "MaNghiViec", c => c.Int(nullable: false));
            DropColumn("dbo.ThanNhans", "Noidung");
            DropColumn("dbo.ThanNhans", "HoTen");
            DropColumn("dbo.ThanNhans", "Moiquanhe");
        }
    }
}
