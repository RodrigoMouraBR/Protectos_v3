using Protectos.Domain.Entities.Filiais;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Filiais
{
    public class FilialEmailMapping : EntityTypeConfiguration<FilialEmail>
    {
        public FilialEmailMapping()
        {
            HasKey(c => c.Id);

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.CadastradoPor)
                .IsRequired();

            Property(c => c.DataAlteracao)
                .IsOptional();

            Property(c => c.AlteradoPor)
                .IsOptional();

            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.TipoEmail)
                .IsRequired();

            HasRequired(c => c.Filial)
               .WithMany(a => a.Emails)
               .HasForeignKey(c => c.FilialId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("FilialEmail");

        }
    }
}
