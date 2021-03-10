namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Chucvu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChucVus",
                c => new
                    {
                        Machucvu = c.String(nullable: false, maxLength: 128),
                        Tenchucvu = c.String(),
                    })
                .PrimaryKey(t => t.Machucvu);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChucVus");
        }
    }
}
