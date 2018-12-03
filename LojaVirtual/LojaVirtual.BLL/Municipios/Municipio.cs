using LojaVirtual.BLL._Base;

namespace LojaVirtual.BLL.Municipios
{
    public class Municipio : EntidadeBase
    {
        public string Nome { get; private set; }
        public int UfId { get; private set; }

        public virtual UF UF { get; private set; }
    }
}
