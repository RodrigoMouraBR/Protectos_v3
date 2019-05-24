using Protectos.Domain.Entities.Faturas;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Faturas
{
    public class FaturaPlanoMapping : EntityTypeConfiguration<FaturaPlano>
    {
        public FaturaPlanoMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);            
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            HasRequired(c => c.Fatura)
              .WithMany(a => a.FaturaPlano)
              .HasForeignKey(c => c.FaturaId);

            HasRequired(c => c.Plano)
              .WithMany(a => a.FaturaPlano)
              .HasForeignKey(c => c.PlanoId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("FaturaPlano");
        }        
    }
}