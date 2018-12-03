using LojaVirtual.BLL.Pedidos;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class PedidoMapeamento : EntityTypeConfiguration<Pedido>
    {
        public PedidoMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.DataDeCadastro)
                .IsRequired();

            Property(t => t.SituacaoDoPedido)
               .IsRequired();

            Property(t => t.SubTotal)
               .IsRequired();

            Property(t => t.Desconto)
               .IsRequired();

            Property(t => t.Frete)
               .IsRequired();

            Property(t => t.ValorTotal)
               .IsRequired();

            HasRequired(t => t.Pessoa)
               .WithMany()
               .HasForeignKey(t => t.PessoaId)
               .WillCascadeOnDelete(false);
        }
    }
}
