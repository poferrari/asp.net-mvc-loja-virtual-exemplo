using LojaVirtual.BLL._Base;

namespace LojaVirtual.BLL.Pessoas.PessoasJuridicas
{
    public class PessoaJuridica 
    {
        public int PessoaId { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; set; }

        public virtual Pessoa Pessoa { get; private set; }
    }
}
