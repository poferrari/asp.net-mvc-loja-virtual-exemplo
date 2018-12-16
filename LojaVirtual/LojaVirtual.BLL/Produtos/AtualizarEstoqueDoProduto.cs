namespace LojaVirtual.BLL.Produtos
{
    public class AtualizarEstoqueDoProduto : IAtualizarEstoqueDoProduto
    {
        public readonly IProdutoRepositorio _produtoRepositorio;

        public AtualizarEstoqueDoProduto(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public bool AlterarEstoque(int produtoId, int quantidade)
        {
            var produto = _produtoRepositorio.Find(produtoId);
            if (produto == null)
                return false;
            var estoque = produto.Quantidade + quantidade;
            produto.AlterarQuantidade(estoque);
            _produtoRepositorio.SalvarTodos();
            return true;
        }
    }
}
