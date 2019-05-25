using Protectos.Domain.Entities.Entidades;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Entidades
{
    public class EntidadeTelefoneMapping : EntityTypeConfiguration<EntidadeTelefone>
    {
        public EntidadeTelefoneMapping()
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

            Property(c => c.Prefixo)
                .HasColumnType("char")
                .HasMaxLength(5)
                .IsRequired();

            Property(c => c.Numero)
                .HasMaxLength(10)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.TipoTelefone)
                .IsRequired();

            HasRequired(c => c.Entidade)
                .WithMany(a => a.Telefones)
                .HasForeignKey(c => c.EntidadeId);
            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("EntidadeTelefone");
        }
    }
}
