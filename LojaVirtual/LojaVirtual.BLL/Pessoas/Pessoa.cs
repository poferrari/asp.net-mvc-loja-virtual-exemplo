using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Clientes.Enums;
using LojaVirtual.BLL.Pessoas.Enderecos;
using LojaVirtual.BLL.Pessoas.PessoasFisicas;
using LojaVirtual.BLL.Pessoas.PessoasJuridicas;
using System.Collections.Generic;

namespace LojaVirtual.BLL.Pessoas
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public ETipoDePessoa TipoDePessoa { get; private set; }

        public virtual PessoaFisica PessoaFisica { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
        public virtual ICollection<Endereco> Enderecos { get; private set; }
    }
}
