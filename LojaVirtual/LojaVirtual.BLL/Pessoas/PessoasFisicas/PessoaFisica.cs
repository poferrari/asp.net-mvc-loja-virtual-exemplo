namespace LojaVirtual.BLL.Pessoas.PessoasFisicas
{
    public class PessoaFisica
    {
        public int PessoaId { get; private set; }
        public string Cpf { get; private set; }

        public virtual Pessoa Pessoa { get; private set; }
    }
}
