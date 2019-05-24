using Protectos.Domain.Entities.Cobrancas;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Cobrancas
{
    public class MotivoExclusaoMapping : EntityTypeConfiguration<MotivoExclusao>
    {
        public MotivoExclusaoMapping()
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
            Property(c => c.CodigoMotivoExclusao)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("MotivoExclusao");
        }
    }
}
