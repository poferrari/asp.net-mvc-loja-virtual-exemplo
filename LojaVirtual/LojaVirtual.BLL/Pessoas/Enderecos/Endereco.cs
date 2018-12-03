using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Municipios;

namespace LojaVirtual.BLL.Pessoas.Enderecos
{
    public class Endereco : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }        
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string InformacoesDeReferencia { get; private set; }
        public int MunicipioId { get; private set; }
        public int PessoaId { get; private set; }

        public virtual Municipio Municipio { get; private set; }        
        public virtual Pessoa Pessoa { get; private set; }
    }
}
