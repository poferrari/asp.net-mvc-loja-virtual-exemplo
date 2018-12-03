using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Produtos;

namespace LojaVirtual.BLL.Pedidos
{
    public class ItemDoPedido : EntidadeBase
    {
        public int ProdutoId { get; private set; }
        public int PedidoId { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }

        public virtual Produto Produto { get; private set; }
        public virtual Pedido Pedido { get; private set; }
    }
}
