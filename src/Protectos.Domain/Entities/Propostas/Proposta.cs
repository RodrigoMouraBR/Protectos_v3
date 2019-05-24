using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Clientes;
using Protectos.Domain.Entities.Cobrancas;
using Protectos.Domain.Entities.Corretores;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Propostas
{
    public class Proposta : Entity<Proposta>
    {
        public Proposta(string numeroProposta, Guid propostaPai, DateTime dataVigencia, Guid beneficiarioId, Guid entidadeId, Guid corretorId, Guid tipoVencimentoReferenciaId, Guid bancoId, Guid motivoExclusaoId, Guid pessoaIdPagadora, Guid clienteIdPagadora, EFormaPagamento formaPagamento, int diaVencimentoReferencia, string numeroAgenciaBanco, string digitoAgenciaBanco, string numeroContaCorrente, string numeroDigitoContaCorrente, string cPFPagador, string cNPJPagador, decimal taxaJuros, decimal taxaMulta, decimal taxaBancaria)
        {
            NumeroProposta = numeroProposta;
            PropostaPai = propostaPai;
            DataVigencia = dataVigencia;
            BeneficiarioId = beneficiarioId;
            EntidadeId = entidadeId;
            CorretorId = corretorId;
            TipoVencimentoReferenciaId = tipoVencimentoReferenciaId;
            BancoId = bancoId;
            MotivoExclusaoId = motivoExclusaoId;
            PessoaIdPagadora = pessoaIdPagadora;
            ClienteIdPagadora = clienteIdPagadora;
            FormaPagamento = formaPagamento;
            DiaVencimentoReferencia = diaVencimentoReferencia;
            NumeroAgenciaBanco = numeroAgenciaBanco;
            DigitoAgenciaBanco = digitoAgenciaBanco;
            NumeroContaCorrente = numeroContaCorrente;
            NumeroDigitoContaCorrente = numeroDigitoContaCorrente;
            CPFPagador = cPFPagador;
            CNPJPagador = cNPJPagador;
            TaxaJuros = taxaJuros;
            TaxaMulta = taxaMulta;
            TaxaBancaria = taxaBancaria;
        }
        protected Proposta()
        {
        }
        public string NumeroProposta { get; private set; }
        public Guid PropostaPai { get; private set; }
        public DateTime DataVigencia { get; private set; }
        public Guid BeneficiarioId { get; private set; }
        public Guid EntidadeId { get; private set; }
        public Guid CorretorId { get; private set; }
        public Guid TipoVencimentoReferenciaId { get; private set; }
        public Guid BancoId { get; private set; }
        public Guid MotivoExclusaoId { get; private set; }
        public Guid PessoaIdPagadora { get; private set; }
        public Guid ClienteIdPagadora { get; private set; }
        public EFormaPagamento FormaPagamento { get; private set; }
        public int DiaVencimentoReferencia { get; private set; }
        public string NumeroAgenciaBanco { get; private set; }
        public string DigitoAgenciaBanco { get; private set; }
        public string NumeroContaCorrente { get; private set; }
        public string NumeroDigitoContaCorrente { get; private set; }
        public string CPFPagador { get; private set; }
        public string CNPJPagador { get; private set; }
        public Decimal TaxaJuros { get; private set; }
        public Decimal TaxaMulta { get; private set; }
        public Decimal TaxaBancaria { get; private set; }

        public virtual Beneficiario Beneficiarios { get; private set; }//
        public virtual TipoVencimentoReferencia TipoVencimentoReferencia { get; private set; }//
        public virtual MotivoExclusao MotivoExclusao { get; private set; }        
        public virtual Banco Banco { get; private set; }
        public virtual Entidade Entidade { get; private set; }
        public virtual Corretor Corretor { get; private set; }
        public virtual Cliente Cliente { get; private set; }

        public override bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }
        private void Validate()
        {
            ValidateProperty();
            ValidationResult = Validate(this);
        }
        private void ValidateProperty()
        {
            RuleFor(c => c.NumeroProposta)
                .NotEmpty().WithMessage("o numero da proposta precisa ser fornecido")
                .Length(1, 50).WithMessage("o numero da proposta precisa ter entre 1 e 10 caracteres");
        }
    }
}
