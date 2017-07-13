namespace EntityFramework.APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FactGeo4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Almacen2",
                c => new
                    {
                        Almacen2Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        direccion_pais = c.String(),
                        direccion_departamento = c.String(),
                        direccion_ciudad = c.String(),
                    })
                .PrimaryKey(t => t.Almacen2Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Almacen2");
        }
    }
}
