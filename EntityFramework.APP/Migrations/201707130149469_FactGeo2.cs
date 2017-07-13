namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FactGeo2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FactGeos", "ciudad_ciudadId", "dbo.Ciudads");
            DropForeignKey("dbo.FactGeos", "departamento_departamentoId", "dbo.Departamentoes");
            DropForeignKey("dbo.FactGeos", "pais_paisId", "dbo.Pais");
            DropIndex("dbo.FactGeos", new[] { "ciudad_ciudadId" });
            DropIndex("dbo.FactGeos", new[] { "departamento_departamentoId" });
            DropIndex("dbo.FactGeos", new[] { "pais_paisId" });
            DropTable("dbo.FactGeos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FactGeos",
                c => new
                    {
                        FactGeoId = c.Int(nullable: false, identity: true),
                        ciudad_ciudadId = c.Int(),
                        departamento_departamentoId = c.Int(),
                        pais_paisId = c.Int(),
                    })
                .PrimaryKey(t => t.FactGeoId);
            
            CreateIndex("dbo.FactGeos", "pais_paisId");
            CreateIndex("dbo.FactGeos", "departamento_departamentoId");
            CreateIndex("dbo.FactGeos", "ciudad_ciudadId");
            AddForeignKey("dbo.FactGeos", "pais_paisId", "dbo.Pais", "paisId");
            AddForeignKey("dbo.FactGeos", "departamento_departamentoId", "dbo.Departamentoes", "departamentoId");
            AddForeignKey("dbo.FactGeos", "ciudad_ciudadId", "dbo.Ciudads", "ciudadId");
        }
    }
}
