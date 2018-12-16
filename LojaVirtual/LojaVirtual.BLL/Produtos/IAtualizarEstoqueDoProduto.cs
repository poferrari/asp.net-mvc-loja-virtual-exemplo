namespace LojaVirtual.BLL.Produtos
{
    public interface IAtualizarEstoqueDoProduto
    {
        bool AlterarEstoque(int produtoId, int quantidade);
    }
}
