using LojaVirtual.BLL.Pedidos.Dto;
using System.Collections.Generic;

namespace LojaVirtual.BLL.Pedidos
{
    public interface IPersistirPedido
    {
        bool ConcluirPedido(PedidoDto pedido, out IEnumerable<string> erros);
    }
}
