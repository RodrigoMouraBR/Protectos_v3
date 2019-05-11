using Protectos.Domain.Entities.Administradoras;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Administradoras
{
    public class AdministradoraMapping : EntityTypeConfiguration<Administradora>
    {
        public AdministradoraMapping()
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
            Property(c => c.Cnpj.Numero)
               .IsRequired()
               .HasMaxLength(14)
               .IsFixedLength()
               .HasColumnAnnotation("Index", new IndexAnnotation(
                   new IndexAttribute("IX_CNPJ_Administradora") { IsUnique = true }));
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
            ToTable("Administradora");
            //HasKey(c => c.Id);
            //Property(c => c.Empresa.RazaoSocial)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(100)
            //    .IsRequired();
            //Property(c => c.Empresa.NomeFantasia)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(100)
            //    .IsRequired();
            //Property(c => c.Empresa.Cnpj.Numero)
            //   .IsRequired()
            //   .HasMaxLength(14)
            //   .IsFixedLength()
            //   .HasColumnAnnotation("Index", new IndexAnnotation(
            //       new IndexAttribute("IX_CNPJ_Administradora") { IsUnique = true }));
            //Property(c => c.Empresa.InscricaoEstadual)
            //    .HasColumnType("char")
            //    .HasMaxLength(14);
            //Property(c => c.Empresa.InscricaoMunicipal)
            //    .HasColumnType("char")
            //    .HasMaxLength(14);
            //Property(c => c.Empresa.Site)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50);  
            //Ignore(c => c.CascadeMode);
            //Ignore(c => c.ValidationResult);
            //ToTable("Administradora");
        }
    }
}
