using Protectos.Domain.Entities.Corretores;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Corretores
{
    public class CorretorEmailMapping : EntityTypeConfiguration<CorretorEmail>
    {
        public CorretorEmailMapping()
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

            HasRequired(c => c.Corretor)
                    .WithMany(a => a.Emails)
                    .HasForeignKey(c => c.CorretorId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("CorretorEmail");
        }
    }
}
