namespace LojaVirtual.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadaQuantidadeDoProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Quantidade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Quantidade");
        }
    }
}
