using LojaVirtual.BLL.Calculadora;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class CalculadoraMapeamento : EntityTypeConfiguration<Calculadora>
    {
        public CalculadoraMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.PrimeiroValor).IsRequired();

            Property(t => t.SegundoValor).IsRequired();
        }
    }
}
