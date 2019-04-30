using Protectos.Domain.Entities.Beneficiarios;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioMapping : EntityTypeConfiguration<Beneficiario>
    {
        public BeneficiarioMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.Sobrenome)
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsRequired();
            Property(c => c.DataNascimento)
               .IsRequired();
            Property(c => c.Sexo)
               .IsRequired();
            Property(c => c.Cpf.Numero)
              .IsRequired()
              .HasMaxLength(11)
              .IsFixedLength();
            Property(c => c.RG)
             .HasColumnType("char")
             .HasMaxLength(14);
            Property(c => c.OrgaoEmissor)
            .HasColumnType("char")
            .HasMaxLength(10);
            Property(c => c.EstadoCivil)
                .IsRequired();
            Property(c => c.Ativo)
               .IsRequired();
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Beneficiario");
        }
    }
}
