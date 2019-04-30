using Protectos.Domain.Entities.Beneficiarios;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Beneficiarios
{
    public class BeneficiarioEmailMapping : EntityTypeConfiguration<BeneficiarioEmail>
    {
        public BeneficiarioEmailMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Email)
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .IsRequired();
            Property(c => c.TipoEmail)
                    .HasColumnType("int")
                    .IsRequired();
            HasRequired(c => c.Beneficiario)
                    .WithMany(a => a.Emails)
                    .HasForeignKey(c => c.BeneficiarioId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("BeneficiarioEmail");
        }
    }
}
