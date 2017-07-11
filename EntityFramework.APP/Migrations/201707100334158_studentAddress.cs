namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropTable("dbo.StudentAddresses");
        }
    }
}
