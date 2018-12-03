using LojaVirtual.BLL.Pessoas.Enderecos;
using LojaVirtual.Resources;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.DAL.Contexto.Mapeamento
{
    public class EnderecoMapeamento : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapeamento()
        {
            HasKey(t => t.Id);

            Property(t => t.Nome)
                .HasMaxLength(Resource.QuantidadeCaracter150)
                .IsRequired();

            Property(t => t.Cep)
               .HasMaxLength(Resource.QuantidadeCaracter10)
               .IsRequired();

            Property(t => t.Bairro)
               .HasMaxLength(Resource.QuantidadeCaracter150)
               .IsRequired();

            Property(t => t.Logradouro)
               .HasMaxLength(Resource.QuantidadeCaracter150)
               .IsRequired();

            Property(t => t.Numero)
               .HasMaxLength(Resource.QuantidadeCaracter10)
               .IsRequired();

            Property(t => t.Complemento)
               .IsOptional();

            Property(t => t.InformacoesDeReferencia)
               .IsOptional();

            HasRequired(t => t.Municipio)
                .WithMany()
                .HasForeignKey(t => t.MunicipioId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.Pessoa)
                .WithMany(t => t.Enderecos)
                .HasForeignKey(t => t.PessoaId)
                .WillCascadeOnDelete(false);
        }
    }
}
