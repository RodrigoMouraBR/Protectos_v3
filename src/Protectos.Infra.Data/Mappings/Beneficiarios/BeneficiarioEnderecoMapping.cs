using Protectos.Domain.Entities.Beneficiarios;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioEnderecoMapping : EntityTypeConfiguration<BeneficiarioEndereco>
    {
        public BeneficiarioEnderecoMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Endereco.Logradouro)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();
            Property(c => c.Endereco.Logradouro)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Bairro)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Cep)
               .HasMaxLength(10)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Endereco.Complemento)
               .HasMaxLength(100)
               .HasColumnType("varchar");
            Property(c => c.Endereco.Cidade)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Estado)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Endereco.Logradouro)
               .HasMaxLength(2)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Endereco.Pais)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            HasRequired(c => c.Beneficiario)
                .WithMany(a => a.Enderecos)
                .HasForeignKey(c => c.BeneficiarioId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("BeneficiarioEndereco");
        }
    }
}
