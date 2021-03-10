namespace QuanLyNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_KTKL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.khenthuongkyluat",
                c => new
                    {
                        id_nv = c.Int(nullable: false, identity: true),
                        khenthuong = c.String(),
                        Lydo = c.String(),
                    })
                .PrimaryKey(t => t.id_nv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.khenthuongkyluat");
        }
    }
}
