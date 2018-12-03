namespace LojaVirtual.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicializarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DepartamentoDoProduto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartamentoId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoId)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .Index(t => t.DepartamentoId)
                .Index(t => t.ProdutoId)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto = c.Decimal(precision: 18, scale: 2),
                        DataDeCadastro = c.DateTime(nullable: false),
                        Removido = c.Boolean(nullable: false),
                        SKU = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImagemDoProduto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Tipo = c.String(nullable: false, maxLength: 10),
                        Caminho = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Cep = c.String(nullable: false, maxLength: 10),
                        Logradouro = c.String(nullable: false, maxLength: 150),
                        Bairro = c.String(nullable: false, maxLength: 150),
                        Numero = c.String(nullable: false, maxLength: 10),
                        Complemento = c.String(),
                        InformacoesDeReferencia = c.String(),
                        MunicipioId = c.Int(nullable: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipio", t => t.MunicipioId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.MunicipioId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Municipio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        UfId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UF", t => t.UfId)
                .Index(t => t.UfId);
            
            CreateTable(
                "dbo.UF",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Sigla = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 150),
                        Senha = c.String(nullable: false, maxLength: 150),
                        TipoDePessoa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Cpf = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        RazaoSocial = c.String(),
                        Cnpj = c.String(),
                        InscricaoEstadual = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.ItemDoPedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        PedidoId = c.Int(nullable: false),
                        NomeProduto = c.String(nullable: false, maxLength: 150),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedido", t => t.PedidoId)
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .Index(t => t.ProdutoId)
                .Index(t => t.PedidoId);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(nullable: false),
                        DataDeCadastro = c.DateTime(nullable: false),
                        SituacaoDoPedido = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Frete = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemDoPedido", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.ItemDoPedido", "PedidoId", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.PessoaJuridica", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.PessoaFisica", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "MunicipioId", "dbo.Municipio");
            DropForeignKey("dbo.Municipio", "UfId", "dbo.UF");
            DropForeignKey("dbo.DepartamentoDoProduto", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.ImagemDoProduto", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.DepartamentoDoProduto", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.DepartamentoDoProduto", "DepartamentoId", "dbo.Departamento");
            DropIndex("dbo.Pedido", new[] { "PessoaId" });
            DropIndex("dbo.ItemDoPedido", new[] { "PedidoId" });
            DropIndex("dbo.ItemDoPedido", new[] { "ProdutoId" });
            DropIndex("dbo.PessoaJuridica", new[] { "PessoaId" });
            DropIndex("dbo.PessoaFisica", new[] { "PessoaId" });
            DropIndex("dbo.Municipio", new[] { "UfId" });
            DropIndex("dbo.Endereco", new[] { "PessoaId" });
            DropIndex("dbo.Endereco", new[] { "MunicipioId" });
            DropIndex("dbo.ImagemDoProduto", new[] { "ProdutoId" });
            DropIndex("dbo.DepartamentoDoProduto", new[] { "Produto_Id" });
            DropIndex("dbo.DepartamentoDoProduto", new[] { "ProdutoId" });
            DropIndex("dbo.DepartamentoDoProduto", new[] { "DepartamentoId" });
            DropTable("dbo.Pedido");
            DropTable("dbo.ItemDoPedido");
            DropTable("dbo.PessoaJuridica");
            DropTable("dbo.PessoaFisica");
            DropTable("dbo.Pessoa");
            DropTable("dbo.UF");
            DropTable("dbo.Municipio");
            DropTable("dbo.Endereco");
            DropTable("dbo.ImagemDoProduto");
            DropTable("dbo.Produto");
            DropTable("dbo.DepartamentoDoProduto");
            DropTable("dbo.Departamento");
        }
    }
}
