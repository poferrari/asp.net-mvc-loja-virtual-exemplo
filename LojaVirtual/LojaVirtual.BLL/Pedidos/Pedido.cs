using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Pedidos.Enums;
using LojaVirtual.BLL.Pessoas;
using System;
using System.Collections.Generic;

namespace LojaVirtual.BLL.Pedidos
{
    public class Pedido : EntidadeBase
    {
        public int PessoaId { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public ESituacaoDoPedido SituacaoDoPedido { get; private set; }
        public decimal SubTotal { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal Frete { get; private set; }
        public decimal ValorTotal { get; private set; }

        public Pedido(int pessoaId, decimal subTotal, decimal desconto, decimal frete, decimal valorTotal)
        {
            PessoaId = pessoaId;
            SubTotal = subTotal;
            Desconto = desconto;
            Frete = frete;
            ValorTotal = valorTotal;
            DataDeCadastro = DateTime.Now;
            SituacaoDoPedido = ESituacaoDoPedido.AguardandoPagamento;
        }

        public virtual Pessoa Pessoa { get; private set; }
        public virtual ICollection<ItemDoPedido> Itens { get; private set; } = new List<ItemDoPedido>();

        public void AdicionarItemDoPedido(ItemDoPedido item)
        {
            Itens.Add(item);
        }
    }
}
