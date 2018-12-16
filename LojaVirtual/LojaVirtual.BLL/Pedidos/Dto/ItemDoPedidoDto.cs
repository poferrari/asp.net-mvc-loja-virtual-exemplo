using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.BLL.Pedidos.Dto
{
    public class ItemDoPedidoDto
    {
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public string NomeProduto { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }        
    }
}
