using Protectos.Domain.Entities.Planos;
using System.Data.Entity.ModelConfiguration;
namespace Protectos.Infra.Data.Mappings.Planos
{
    public class PlanoMapping : EntityTypeConfiguration<Plano>
    {
        public PlanoMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            Property(c => c.CodigoPlano)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.PlanoTipo)
                .IsRequired();
            Property(c => c.CodigoPlanoANS)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.Coparticipacao)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.CodigoAcomodacao)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.CodigoPlanoSuspenso)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();          

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Plano");
        }
    }
}
