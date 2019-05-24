using Protectos.Domain.Entities.Operadoras;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Operadoras
{
    public class OperadoraEntidadeMapping : EntityTypeConfiguration<OperadoraEntidade>
    {
        public OperadoraEntidadeMapping()
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

            Property(c => c.OperadoraId)
                .IsRequired();

            Property(c => c.EntidadeId)
               .IsRequired();

            HasRequired(c => c.Operadora)
                .WithMany(a => a.OperadoraEntidade)
                .HasForeignKey(c => c.OperadoraId);

            HasRequired(c => c.Entidade)
                .WithMany(a => a.OperadoraEntidade)
                .HasForeignKey(c => c.EntidadeId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("OperadoraEntidade");

        }
    }
}
