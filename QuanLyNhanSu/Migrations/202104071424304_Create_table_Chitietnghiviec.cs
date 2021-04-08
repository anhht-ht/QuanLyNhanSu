namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Chitietnghiviec : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chitietnghiviecs",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        Manghiviec = c.String(),
                        Ngaynghi = c.String(),
                        Thoigiannghi = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chitietnghiviecs");
        }
    }
}
