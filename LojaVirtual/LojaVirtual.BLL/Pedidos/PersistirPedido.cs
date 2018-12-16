using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Pedidos.Dto;
using LojaVirtual.BLL.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.BLL.Pedidos
{
    public class PersistirPedido : IPersistirPedido
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        private readonly IAtualizarEstoqueDoProduto _atualizarEstoqueDoProduto;
        private readonly IUnitOfWork _unitOfWork;

        public PersistirPedido(IPedidoRepositorio pedidoRepositorio,
            IAtualizarEstoqueDoProduto atualizarEstoqueDoProduto,
            IUnitOfWork unitOfWork)
        {
            _pedidoRepositorio = pedidoRepositorio;
            _atualizarEstoqueDoProduto = atualizarEstoqueDoProduto;
            _unitOfWork = unitOfWork;
        }

        public bool ConcluirPedido(PedidoDto pedidoDto, out IEnumerable<string> erros)
        {
            if (pedidoDto == null)
                throw new ArgumentNullException(nameof(pedidoDto));

            erros = new List<string>();
            _unitOfWork.AbrirTransacao();

            pedidoDto.SubTotal = pedidoDto.Itens
                .Sum(t => t.Valor * t.Quantidade);

            pedidoDto.ValorTotal = (pedidoDto.SubTotal - pedidoDto.Desconto) + pedidoDto.Frete;

            var pedido = new Pedido(
                pedidoDto.PessoaId,
                pedidoDto.SubTotal,
                pedidoDto.Desconto,
                pedidoDto.Frete,
                pedidoDto.ValorTotal);

            pedidoDto.Itens.ForEach(t => pedido.AdicionarItemDoPedido(
                new ItemDoPedido
                (
                    t.ProdutoId,
                    t.NomeProduto,
                    t.Valor,
                    t.Quantidade
                )));

            _pedidoRepositorio.Adicionar(pedido);
            erros = _pedidoRepositorio.ObterErros();
            if (erros.Any())
            {
                _unitOfWork.Rollback();
                return false;
            }

            foreach (var item in pedido.Itens)            
                _atualizarEstoqueDoProduto.AlterarEstoque(item.ProdutoId, -item.Quantidade);
            _unitOfWork.Commit();

            return true;
        }
    }
}
