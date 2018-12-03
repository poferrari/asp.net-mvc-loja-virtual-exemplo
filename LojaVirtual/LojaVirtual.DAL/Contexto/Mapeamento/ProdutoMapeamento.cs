using LojaVirtual.BLL.Produtos;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class ProdutoMapeamento : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Descricao)                
                .IsOptional();

            Property(t => t.Preco)                
                .IsRequired();

            Property(t => t.Desconto)
                .IsOptional();

            Property(t => t.DataDeCadastro)
                .IsRequired();

            Property(t => t.SKU)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();
        }
    }
}
