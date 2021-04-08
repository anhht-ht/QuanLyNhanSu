namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TrinhDo_ChuyenMon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrinhDo_ChuyenMons",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        Ma_trinhdo = c.String(),
                        Machuyenmon = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrinhDo_ChuyenMons");
        }
    }
}
