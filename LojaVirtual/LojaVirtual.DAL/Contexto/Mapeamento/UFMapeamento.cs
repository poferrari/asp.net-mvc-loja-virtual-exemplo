using LojaVirtual.BLL.Municipios;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class UFMapeamento : EntityTypeConfiguration<UF>
    {
        public UFMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Sigla)
                .HasMaxLength(Resource.QuantidadeCaracter2)
                .IsRequired();

            HasIndex(t => new { t.Nome, t.Sigla })
                .IsUnique();
        }
    }
}
