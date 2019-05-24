using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Cobrancas;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Faturas.Enums;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Generics.Enums;
using System;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Faturas
{
    public class Fatura : Entity<Fatura>
    {
        public Fatura(string nomeFatura, 
                        string numeroFatura, 
                        int mesReajuste, 
                        int diaVigencia, 
                        int vencimentoBoleto, 
                        int vencimentoDBA, 
                        int permiteCobrancaDobrada, 
                        decimal taxaJuros, 
                        decimal taxaMulta,
                        decimal taxaBancaria, 
                        EFaturaPlanoTipo faturaCaracteristicaTipo, 
                        EFaturaTipo faturaTipo, 
                        bool ajustaPrecoMesAniversario, 
                        EStatus status, 
                        Guid entidadeId, 
                        Guid operadoraId)
        {
            NomeFatura = nomeFatura;
            NumeroFatura = numeroFatura;
            MesReajuste = mesReajuste;
            DiaVigencia = diaVigencia;
            VencimentoBoleto = vencimentoBoleto;
            VencimentoDBA = vencimentoDBA;
            PermiteCobrancaDobrada = permiteCobrancaDobrada;
            TaxaJuros = taxaJuros;
            TaxaMulta = taxaMulta;
            TaxaBancaria = taxaBancaria;
            FaturaCaracteristicaTipo = faturaCaracteristicaTipo;
            FaturaTipo = faturaTipo;
            AjustaPrecoMesAniversario = ajustaPrecoMesAniversario;
            Status = status;
            EntidadeId = entidadeId;
            OperadoraId = operadoraId;
           //FaturaCarencia = new List<FaturaCarencia>();
        }
        protected Fatura()
        {
        }
        public string NomeFatura { get; private set; }
        public string NumeroFatura { get; private set; }
        public int MesReajuste { get; private set; }
        public int DiaVigencia { get; private set; }
        public int VencimentoBoleto { get; private set; }
        public int VencimentoDBA { get; private set; }
        public int PermiteCobrancaDobrada { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal TaxaMulta { get; private set; }
        public decimal TaxaBancaria { get; private set; }
        public EFaturaPlanoTipo FaturaCaracteristicaTipo { get; private set; }
        public EFaturaTipo FaturaTipo { get; private set; }
        public bool AjustaPrecoMesAniversario { get; private set; }
        public EStatus Status { get; private set; }
        public Guid EntidadeId { get; private set; }
        public Guid OperadoraId { get; private set; }
        public virtual Entidade Entidade { get; private set; }
        public virtual Operadora Operadora { get; private set; }
        public virtual ICollection<FaturaCarencia> FaturaCarencia { get; private set; }
        public virtual ICollection<FaturaPlano> FaturaPlano { get; private set; }
        public virtual ICollection<Precificacao> Precificacao { get; private set; }
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
            RuleFor(c => c.NomeFatura)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 100).WithMessage("o telefone precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.NumeroFatura)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");
        }

    }
}
