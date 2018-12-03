using LojaVirtual.BLL.Municipios;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class MunicipioMapeamento : EntityTypeConfiguration<Municipio>
    {
        public MunicipioMapeamento()
        {
            HasKey(x => x.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();
            
            HasRequired(t => t.UF)
               .WithMany(t => t.Municipios)
               .HasForeignKey(t => t.UfId)
               .WillCascadeOnDelete(false);
        }
    }
}
