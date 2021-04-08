namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NhanViens");
            AddColumn("dbo.NhanViens", "MaNV", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.NhanViens", "MaChucVu", c => c.Int(nullable: false));
            AddColumn("dbo.NhanViens", "HoTen", c => c.String());
            AddColumn("dbo.NhanViens", "NgaySinh", c => c.String());
            AddColumn("dbo.NhanViens", "QueQuan", c => c.String());
            AddColumn("dbo.NhanViens", "DanToc", c => c.String());
            AddColumn("dbo.NhanViens", "ChungMinhThu", c => c.String());
            AddColumn("dbo.NhanViens", "Ma_PhongBan", c => c.String());
            AddPrimaryKey("dbo.NhanViens", "MaNV");
            DropColumn("dbo.NhanViens", "id");
            DropColumn("dbo.NhanViens", "name");
            DropColumn("dbo.NhanViens", "phone");
            DropColumn("dbo.NhanViens", "address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NhanViens", "address", c => c.String());
            AddColumn("dbo.NhanViens", "phone", c => c.String(nullable: false, maxLength: 14));
            AddColumn("dbo.NhanViens", "name", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.NhanViens", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.NhanViens");
            DropColumn("dbo.NhanViens", "Ma_PhongBan");
            DropColumn("dbo.NhanViens", "ChungMinhThu");
            DropColumn("dbo.NhanViens", "DanToc");
            DropColumn("dbo.NhanViens", "QueQuan");
            DropColumn("dbo.NhanViens", "NgaySinh");
            DropColumn("dbo.NhanViens", "HoTen");
            DropColumn("dbo.NhanViens", "MaChucVu");
            DropColumn("dbo.NhanViens", "MaNV");
            AddPrimaryKey("dbo.NhanViens", "id");
        }
    }
}
