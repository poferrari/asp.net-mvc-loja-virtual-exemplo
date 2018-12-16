using System.Collections.Generic;

namespace LojaVirtual.BLL.Pedidos.Dto
{
    public class PedidoDto
    {
        public int PessoaId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal ValorTotal { get; set; }

        public virtual List<ItemDoPedidoDto> Itens { get; set; } = new List<ItemDoPedidoDto>();
    }
}
