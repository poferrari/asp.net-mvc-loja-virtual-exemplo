using LojaVirtual.BLL.Departamentos;
using LojaVirtual.BLL.Municipios;
using LojaVirtual.BLL.Pedidos;
using LojaVirtual.BLL.Pessoas;
using LojaVirtual.BLL.Pessoas.Enderecos;
using LojaVirtual.BLL.Pessoas.PessoasFisicas;
using LojaVirtual.BLL.Pessoas.PessoasJuridicas;
using LojaVirtual.BLL.Produtos;
using LojaVirtual.DAL.Contexto.Mapeamento;
using LojaVirtual.DAL.Migrations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace LojaVirtual.DAL.Contexto
{
    public class LojaVirtualContexto : DbContext
    {
        public LojaVirtualContexto()
           : base(typeof(LojaVirtualContexto).Name)
        {
            IniciarContexto();
        }

        private void IniciarContexto()
        {            
            Database.SetInitializer(new CreateDatabaseIfNotExists<LojaVirtualContexto>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LojaVirtualContexto, Configuration>());

            Configuration.ValidateOnSaveEnabled = false;
#if DEBUG
            Database.Log = t => Debug.Write(t);
#endif
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<UF> UFs { get; set; }
        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ImagemDoProduto> ImagensDoProduto { get; set; }
        public DbSet<DepartamentoDoProduto> DepartamentosDoProduto { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemDoPedido> ItensDoPedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new PessoaMapeamento());
            modelBuilder.Configurations.Add(new PessoaFisicaMapeamento());
            modelBuilder.Configurations.Add(new PessoaJuridicaMapeamento());
            modelBuilder.Configurations.Add(new EnderecoMapeamento());

            modelBuilder.Configurations.Add(new UFMapeamento());
            modelBuilder.Configurations.Add(new MunicipioMapeamento());

            modelBuilder.Configurations.Add(new DepartamentoMapeamento());

            modelBuilder.Configurations.Add(new ProdutoMapeamento());
            modelBuilder.Configurations.Add(new ImagemDoProdutoMapeamento());
            modelBuilder.Configurations.Add(new DepartamentoDoProdutoMapeamento());

            modelBuilder.Configurations.Add(new PedidoMapeamento());
            modelBuilder.Configurations.Add(new ItemDoPedidoMapeamento());

            base.OnModelCreating(modelBuilder);
        }
    }
}
