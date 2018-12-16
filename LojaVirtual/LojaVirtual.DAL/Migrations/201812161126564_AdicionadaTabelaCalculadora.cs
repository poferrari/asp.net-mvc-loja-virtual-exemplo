namespace LojaVirtual.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadaTabelaCalculadora : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calculadora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrimeiroValor = c.Double(nullable: false),
                        SegundoValor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Calculadora");
        }
    }
}
