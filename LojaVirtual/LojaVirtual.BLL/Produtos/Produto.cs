using LojaVirtual.BLL._Base;
using System;
using System.Collections.Generic;

namespace LojaVirtual.BLL.Produtos
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public decimal? Desconto { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public bool Removido { get; private set; }
        public string SKU { get; private set; }

        public virtual ICollection<DepartamentoDoProduto> Departamentos { get; private set; }
        public virtual ICollection<ImagemDoProduto> Imagens { get; private set; }
    }
}
