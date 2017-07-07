namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "standardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "standardId" });
            AlterColumn("dbo.Students", "standardId", c => c.Int());
            CreateIndex("dbo.Students", "standardId");
            AddForeignKey("dbo.Students", "standardId", "dbo.Standards", "standardId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "standardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "standardId" });
            AlterColumn("dbo.Students", "standardId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "standardId");
            AddForeignKey("dbo.Students", "standardId", "dbo.Standards", "standardId", cascadeDelete: true);
        }
    }
}
