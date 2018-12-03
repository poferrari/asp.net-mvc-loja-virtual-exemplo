using LojaVirtual.BLL.Pedidos;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class ItemDoPedidoMapeamento : EntityTypeConfiguration<ItemDoPedido>
    {
        public ItemDoPedidoMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.NomeProduto)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Quantidade)                
                .IsRequired();

            Property(t => t.Valor)
                .IsRequired();

            HasRequired(t => t.Produto)
                .WithMany()
                .HasForeignKey(t => t.ProdutoId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.Pedido)
                .WithMany(t => t.Itens)
                .HasForeignKey(t => t.PedidoId)
                .WillCascadeOnDelete(false);
        }
    }
}
