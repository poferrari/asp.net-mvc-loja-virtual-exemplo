using LojaVirtual.BLL._Base;
using System.Collections.Generic;

namespace LojaVirtual.BLL.Municipios
{
    public class UF : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public virtual ICollection<Municipio> Municipios { get; private set; }
    }
}
