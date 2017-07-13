namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaisesDptoCiudad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudads",
                c => new
                    {
                        ciudadId = c.Int(nullable: false, identity: true),
                        ciudad = c.String(),
                        Departamento_departamentoId = c.Int(),
                    })
                .PrimaryKey(t => t.ciudadId)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_departamentoId)
                .Index(t => t.Departamento_departamentoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        departamentoId = c.Int(nullable: false, identity: true),
                        deparmento = c.String(),
                        Pais_paisId = c.Int(),
                    })
                .PrimaryKey(t => t.departamentoId)
                .ForeignKey("dbo.Pais", t => t.Pais_paisId)
                .Index(t => t.Pais_paisId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        paisId = c.Int(nullable: false, identity: true),
                        pais = c.String(),
                    })
                .PrimaryKey(t => t.paisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departamentoes", "Pais_paisId", "dbo.Pais");
            DropForeignKey("dbo.Ciudads", "Departamento_departamentoId", "dbo.Departamentoes");
            DropIndex("dbo.Departamentoes", new[] { "Pais_paisId" });
            DropIndex("dbo.Ciudads", new[] { "Departamento_departamentoId" });
            DropTable("dbo.Pais");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Ciudads");
        }
    }
}
