using Protectos.Domain.Entities.Corretoras;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Corretoras
{
    public class CorretoraMapping : EntityTypeConfiguration<Corretora>
    {
        public CorretoraMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.RazaoSocial)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.NomeFantasia)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.Cnpj)
               .IsRequired()
               .HasMaxLength(14)
               .IsFixedLength()
               .HasColumnAnnotation("Index", new IndexAnnotation(
                   new IndexAttribute("IX_CNPJ_Corretora") { IsUnique = true }));
            Property(c => c.InscricaoEstadual)
                .HasColumnType("char")
                .HasMaxLength(14);
            Property(c => c.InscricaoMunicipal)
                .HasColumnType("char")
                .HasMaxLength(14);
            Property(c => c.Site)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Corretora");
        }

    }
}
