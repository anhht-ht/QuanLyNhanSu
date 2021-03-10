namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30),
                        phone = c.String(nullable: false, maxLength: 14),
                        gioitinh = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
