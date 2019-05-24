using Protectos.Domain.Entities.Propostas;
using System.Data.Entity.ModelConfiguration;

namespace Protectos.Infra.Data.Mappings.Propostas
{
    public class PropostaMapping : EntityTypeConfiguration<Proposta>
    {
        public PropostaMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Ativo);
            Property(c => c.DataCadastro)
                .IsRequired();
            Property(c => c.CadastradoPor)
                .IsRequired();
            Property(c => c.DataAlteracao)
                .IsOptional();
            Property(c => c.AlteradoPor)
                .IsOptional();

            Property(c => c.NumeroProposta)
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(c => c.PropostaPai)
                .IsOptional();

            Property(c => c.DataVigencia)
               .IsOptional();

            Property(c => c.BeneficiarioId)
                .IsOptional();

            Property(c => c.EntidadeId)
               .IsOptional();

            Property(c => c.CorretorId)
               .IsOptional();

            Property(c => c.TipoVencimentoReferenciaId)
               .IsOptional();

            Property(c => c.BancoId)
               .IsOptional();

            Property(c => c.MotivoExclusaoId)
               .IsOptional();

            Property(c => c.PessoaIdPagadora)
               .IsOptional();

            Property(c => c.ClienteIdPagadora)
               .IsOptional();

            Property(c => c.FormaPagamento)
               .IsOptional();

            Property(c => c.DiaVencimentoReferencia)
               .IsOptional();

            Property(c => c.NumeroAgenciaBanco)
                .HasColumnType("char")
                .HasMaxLength(20)
               .IsOptional();

            Property(c => c.DigitoAgenciaBanco)
                .HasColumnType("char")
                .HasMaxLength(10)
               .IsOptional();

            Property(c => c.NumeroContaCorrente)
                .HasColumnType("char")
                .HasMaxLength(20)
               .IsOptional();

            Property(c => c.NumeroDigitoContaCorrente)
                .HasColumnType("char")
                .HasMaxLength(10)
               .IsOptional();

            Property(c => c.CPFPagador)
                .HasColumnType("char")
                .HasMaxLength(11)
               .IsOptional();

            Property(c => c.CNPJPagador)
                .HasColumnType("char")
                .HasMaxLength(14)
               .IsOptional();

            Property(c => c.TaxaJuros)
               .IsOptional();

            Property(c => c.TaxaMulta)
               .IsOptional();

            Property(c => c.TaxaBancaria)
               .IsOptional();

            HasRequired(c => c.Beneficiarios)//
              .WithMany(a => a.Propostas)
              .HasForeignKey(c => c.BeneficiarioId);

            HasRequired(c => c.TipoVencimentoReferencia)//
              .WithMany(a => a.Propostas)
              .HasForeignKey(c => c.TipoVencimentoReferenciaId);

            HasRequired(c => c.MotivoExclusao)//
              .WithMany(a => a.Propostas)
              .HasForeignKey(c => c.MotivoExclusaoId);

            HasRequired(c => c.Banco)//
             .WithMany(a => a.Propostas)
             .HasForeignKey(c => c.BancoId);

            HasRequired(c => c.Entidade)//
             .WithMany(a => a.Propostas)
             .HasForeignKey(c => c.EntidadeId);

            HasRequired(c => c.Corretor)//
            .WithMany(a => a.Propostas)
            .HasForeignKey(c => c.CorretorId);

            HasRequired(c => c.Cliente)//
           .WithMany(a => a.Propostas)
           .HasForeignKey(c => c.ClienteIdPagadora);

            Ignore(c => c.CascadeMode);
            Ignore(c => c.ValidationResult);
            ToTable("Proposta");

        }
    }
}
