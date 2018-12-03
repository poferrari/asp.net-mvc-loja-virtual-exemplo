using LojaVirtual.BLL.Pessoas;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class PessoaMapeamento : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapeamento()
        {
            HasKey(x => x.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Email)
                .HasMaxLength(Resource.QuantidadeCaracter150)                
                .IsRequired();

            Property(t => t.Senha)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            HasIndex(t => t.Email)
                .IsUnique();
        }
    }
}
