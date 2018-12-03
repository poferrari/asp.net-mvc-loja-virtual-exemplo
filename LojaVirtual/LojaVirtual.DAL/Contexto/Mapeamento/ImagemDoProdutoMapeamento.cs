using LojaVirtual.BLL.Produtos;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class ImagemDoProdutoMapeamento : EntityTypeConfiguration<ImagemDoProduto>
    {
        public ImagemDoProdutoMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Tipo)
                .HasMaxLength(Resource.QuantidadeCaracter10)
                .IsRequired();

            Property(t => t.Caminho)
                .HasMaxLength(Resource.QuantidadeCaracter300)
                .IsRequired();

            HasRequired(t => t.Produto)
                .WithMany(t => t.Imagens)
                .HasForeignKey(t => t.ProdutoId)
                .WillCascadeOnDelete(false);
        }
    }
}
