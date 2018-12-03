using LojaVirtual.BLL.Pessoas.PessoasFisicas;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class PessoaFisicaMapeamento : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMapeamento()
        {
            HasKey(x => x.PessoaId);

            Property(t => t.PessoaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(t => t.Pessoa)
                .WithOptional(t => t.PessoaFisica);
        }
    }
}
