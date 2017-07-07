namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        standardId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.standardId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        dateOfBirth = c.DateTime(),
                        photo = c.Binary(),
                        height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        weight = c.Single(nullable: false),
                        standardId = c.Int(nullable: false),
                        teacher_teacherId = c.Int(),
                    })
                .PrimaryKey(t => t.studentId)
                .ForeignKey("dbo.Standards", t => t.standardId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.teacher_teacherId)
                .Index(t => t.standardId)
                .Index(t => t.teacher_teacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        teacherId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.teacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "teacher_teacherId", "dbo.Teachers");
            DropForeignKey("dbo.Students", "standardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "teacher_teacherId" });
            DropIndex("dbo.Students", new[] { "standardId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Standards");
        }
    }
}
