using LojaVirtual.BLL._Base;

namespace LojaVirtual.BLL.Produtos
{
    public class ImagemDoProduto : EntidadeBase
    {
        public int ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public string Caminho { get; private set; }

        public virtual Produto Produto { get; private set; }
    }
}
