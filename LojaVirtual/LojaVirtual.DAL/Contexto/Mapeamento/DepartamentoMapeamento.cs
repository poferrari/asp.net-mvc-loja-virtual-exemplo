using LojaVirtual.BLL.Departamentos;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class DepartamentoMapeamento : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Descricao)
               .IsOptional();
        }
    }
}
