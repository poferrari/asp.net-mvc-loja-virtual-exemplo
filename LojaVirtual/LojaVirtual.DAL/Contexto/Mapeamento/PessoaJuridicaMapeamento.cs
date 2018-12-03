using LojaVirtual.BLL.Pessoas.PessoasJuridicas;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class PessoaJuridicaMapeamento : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaMapeamento()
        {
            HasKey(x => x.PessoaId);

            Property(t => t.PessoaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(t => t.Pessoa)
                .WithOptional(t => t.PessoaJuridica);
        }
    }
}
