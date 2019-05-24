using Protectos.Domain.Entities.Cobrancas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Mappings.Cobrancas
{
    public class PrecificacaoMapping : EntityTypeConfiguration<Precificacao>
    {
        public PrecificacaoMapping()
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

            Property(c => c.IdadeInicial)
                .IsRequired();
            Property(c => c.IdadeFinal)
                .IsRequired();

            Property(c => c.ValorPlanoTitular)
                .IsRequired();

            Property(c => c.ValorPlanoDependente)
                .IsRequired();

            Property(c => c.ValorPlanoAgregado)
                .IsRequired();

            Property(c => c.ValorPlanoTitularNet)
                .IsRequired();

            Property(c => c.ValorPlanoDependenteNet)
                .IsRequired();

            Property(c => c.ValorPlanoAgregadoNet)
                .IsRequired();

            Property(c => c.DataInicio)
                .IsRequired();

            Property(c => c.ValorPorcentagemPFP)
                .IsRequired();

            Property(c => c.Status)
                .IsRequired();

            Property(c => c.PlanoId)
                .IsRequired();

            Property(c => c.FaturaId)
                .IsRequired();


            HasRequired(c => c.Plano)
              .WithMany(a => a.Precificacao)
              .HasForeignKey(c => c.PlanoId);

            HasRequired(c => c.Fatura)
             .WithMany(a => a.Precificacao)
             .HasForeignKey(c => c.FaturaId);



            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Precificacao");
        }
    }
}
