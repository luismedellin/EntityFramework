namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Courses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.courseId);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_studentId = c.Int(nullable: false),
                        Course_courseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_studentId, t.Course_courseId })
                .ForeignKey("dbo.Students", t => t.Student_studentId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_courseId, cascadeDelete: true)
                .Index(t => t.Student_studentId)
                .Index(t => t.Course_courseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", "Course_courseId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_studentId", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "Course_courseId" });
            DropIndex("dbo.StudentCourses", new[] { "Student_studentId" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Courses");
        }
    }
}
