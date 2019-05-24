using Protectos.Domain.Entities.Faturas;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Faturas
{
    public class FaturaMapping : EntityTypeConfiguration<Fatura>
    {
        public FaturaMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao);
            Property(c => c.AlteradoPor);
            Property(c => c.NomeFatura)
            .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.NumeroFatura)
            .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.MesReajuste)
                .IsRequired();
            Property(c => c.DiaVigencia)
                .IsRequired();
            Property(c => c.VencimentoBoleto)
                .IsRequired();
            Property(c => c.VencimentoDBA)
                .IsRequired();
            Property(c => c.PermiteCobrancaDobrada)
                .IsRequired();
            Property(c => c.TaxaJuros)
                .IsRequired();
            Property(c => c.TaxaMulta)
                .IsRequired();
            Property(c => c.TaxaBancaria)
                .IsRequired();
            Property(c => c.FaturaCaracteristicaTipo)
                .IsRequired();
            Property(c => c.FaturaTipo)
                .IsRequired();
            Property(c => c.AjustaPrecoMesAniversario)
                .IsRequired();
            Property(c => c.Status)
               .IsRequired();

            HasRequired(c => c.Entidade)
               .WithMany(a => a.Faturas)
               .HasForeignKey(c => c.EntidadeId);

            HasRequired(c => c.Operadora)
               .WithMany(a => a.Faturas)
               .HasForeignKey(c => c.OperadoraId);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);

            ToTable("Fatura");
        }
    }
}
