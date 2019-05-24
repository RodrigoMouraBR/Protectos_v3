using Protectos.Domain.Entities.Beneficiarios;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioEmailMapping : EntityTypeConfiguration<BeneficiarioEmail>
    {
        public BeneficiarioEmailMapping()
        {
            HasKey(c => c.Id);

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.DataCadastro)
                .HasColumnType("DateTime")
                .IsRequired();

            Property(c => c.CadastradoPor)
                .IsRequired();

            Property(c => c.DataAlteracao)
                .HasColumnType("DateTime")
                .IsOptional();

            Property(c => c.AlteradoPor)
                .IsOptional();

            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.TipoEmail)
                .IsRequired();

            HasRequired(c => c.Beneficiarios)
                    .WithMany(a => a.Emails)
                    .HasForeignKey(c => c.BeneficiarioId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("BeneficiarioEmail");
        }
    }
}
