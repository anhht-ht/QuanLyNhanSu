namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_ChuyenMon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuyenMons",
                c => new
                    {
                        Machuyenmon = c.Int(nullable: false, identity: true),
                        Tenchuyenmon = c.String(),
                    })
                .PrimaryKey(t => t.Machuyenmon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChuyenMons");
        }
    }
}
