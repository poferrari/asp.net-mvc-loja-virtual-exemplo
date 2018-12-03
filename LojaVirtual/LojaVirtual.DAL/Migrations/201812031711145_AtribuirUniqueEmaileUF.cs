namespace LojaVirtual.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtribuirUniqueEmaileUF : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UF", new[] { "Nome", "Sigla" }, unique: true);
            CreateIndex("dbo.Pessoa", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pessoa", new[] { "Email" });
            DropIndex("dbo.UF", new[] { "Nome", "Sigla" });
        }
    }
}
