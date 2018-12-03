using LojaVirtual.BLL.Produtos;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class DepartamentoDoProdutoMapeamento : EntityTypeConfiguration<DepartamentoDoProduto>
    {
        public DepartamentoDoProdutoMapeamento()
        {
            HasKey(t => t.Id);

            HasRequired(t => t.Departamento)
                .WithMany()
                .HasForeignKey(t => t.DepartamentoId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.Produto)
                .WithMany()
                .HasForeignKey(t => t.ProdutoId)
                .WillCascadeOnDelete(false);
        }
    }
}
