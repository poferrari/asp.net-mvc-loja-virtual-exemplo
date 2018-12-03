using LojaVirtual.BLL._Base;

namespace LojaVirtual.BLL.CategoriasDeProduto
{
    public class Departamento : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
    }
}
