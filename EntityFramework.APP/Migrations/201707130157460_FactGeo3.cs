namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FactGeo3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Almacens",
                c => new
                    {
                        almacenId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        title = c.String(),
                        facGeo_FactGeoId = c.Int(),
                    })
                .PrimaryKey(t => t.almacenId)
                .ForeignKey("dbo.FactGeos", t => t.facGeo_FactGeoId)
                .Index(t => t.facGeo_FactGeoId);
            
            CreateTable(
                "dbo.FactGeos",
                c => new
                    {
                        FactGeoId = c.Int(nullable: false, identity: true),
                        ciudad_ciudadId = c.Int(),
                        departamento_departamentoId = c.Int(),
                        pais_paisId = c.Int(),
                    })
                .PrimaryKey(t => t.FactGeoId)
                .ForeignKey("dbo.Ciudads", t => t.ciudad_ciudadId)
                .ForeignKey("dbo.Departamentoes", t => t.departamento_departamentoId)
                .ForeignKey("dbo.Pais", t => t.pais_paisId)
                .Index(t => t.ciudad_ciudadId)
                .Index(t => t.departamento_departamentoId)
                .Index(t => t.pais_paisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Almacens", "facGeo_FactGeoId", "dbo.FactGeos");
            DropForeignKey("dbo.FactGeos", "pais_paisId", "dbo.Pais");
            DropForeignKey("dbo.FactGeos", "departamento_departamentoId", "dbo.Departamentoes");
            DropForeignKey("dbo.FactGeos", "ciudad_ciudadId", "dbo.Ciudads");
            DropIndex("dbo.FactGeos", new[] { "pais_paisId" });
            DropIndex("dbo.FactGeos", new[] { "departamento_departamentoId" });
            DropIndex("dbo.FactGeos", new[] { "ciudad_ciudadId" });
            DropIndex("dbo.Almacens", new[] { "facGeo_FactGeoId" });
            DropTable("dbo.FactGeos");
            DropTable("dbo.Almacens");
        }
    }
}
