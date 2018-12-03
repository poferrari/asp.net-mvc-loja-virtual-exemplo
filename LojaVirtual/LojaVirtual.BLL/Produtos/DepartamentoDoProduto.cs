using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Departamentos;

namespace LojaVirtual.BLL.Produtos
{
    public class DepartamentoDoProduto : EntidadeBase
    {
        public int DepartamentoId { get; private set; }
        public int ProdutoId { get; private set; }

        public virtual Departamento Departamento { get; private set; }
        public virtual Produto Produto { get; private set; }
    }
}
