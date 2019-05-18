using Protectos.Domain.Entities.Beneficiarios;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioEnderecoMapping : EntityTypeConfiguration<BeneficiarioEndereco>
    {
        public BeneficiarioEnderecoMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            Property(c => c.Logradouro)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Bairro)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Cep)
               .HasMaxLength(10)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Complemento)
               .HasMaxLength(100)
               .HasColumnType("varchar");
            Property(c => c.Cidade)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.Estado)
               .HasMaxLength(50)
               .HasColumnType("varchar")
               .IsRequired();
            Property(c => c.UF)
               .HasMaxLength(2)
               .HasColumnType("char")
               .IsRequired();
            Property(c => c.Pais)
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
