namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Congtac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Congtacs",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        Ngay = c.String(),
                        Congviec = c.String(),
                        Chucvu = c.String(),
                        Phongban = c.String(),
                        Noilamviec = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Congtacs");
        }
    }
}
