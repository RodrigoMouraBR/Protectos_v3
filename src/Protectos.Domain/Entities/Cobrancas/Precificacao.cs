using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Planos;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Cobrancas
{
    public class Precificacao : Entity<Precificacao>
    {
        public Precificacao(int idadeInicial, int idadeFinal, decimal valorPlanoTitular, decimal valorPlanoDependente, decimal valorPlanoAgregado, decimal valorPlanoTitularNet, decimal valorPlanoDependenteNet, decimal valorPlanoAgregadoNet, DateTime dataInicio, decimal valorPorcentagemPFP, EStatus status, Guid planoId, Guid faturaId)
        {
            IdadeInicial = idadeInicial;
            IdadeFinal = idadeFinal;
            ValorPlanoTitular = valorPlanoTitular;
            ValorPlanoDependente = valorPlanoDependente;
            ValorPlanoAgregado = valorPlanoAgregado;
            ValorPlanoTitularNet = valorPlanoTitularNet;
            ValorPlanoDependenteNet = valorPlanoDependenteNet;
            ValorPlanoAgregadoNet = valorPlanoAgregadoNet;
            DataInicio = dataInicio;
            ValorPorcentagemPFP = valorPorcentagemPFP;
            Status = status;
            PlanoId = planoId;
            FaturaId = faturaId;
        }
        protected Precificacao()
        {
        }
        public int IdadeInicial { get; private set; }
        public int IdadeFinal { get; private set; }
        public Decimal ValorPlanoTitular { get; private set; }
        public Decimal ValorPlanoDependente { get; set; }
        public Decimal ValorPlanoAgregado { get; private set; }
        public Decimal ValorPlanoTitularNet { get; private set; }
        public Decimal ValorPlanoDependenteNet { get; set; }
        public Decimal ValorPlanoAgregadoNet { get; private set; }
        public DateTime DataInicio { get; private set; }
        public Decimal ValorPorcentagemPFP { get; private set; }
        public EStatus Status { get; private set; }
        public Guid PlanoId { get; private set; }
        public Guid FaturaId { get; private set; }
        public virtual Plano Plano { get; private set; }
        public virtual Fatura Fatura { get; private set; }

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
            RuleFor(c => c.IdadeInicial)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido");

            RuleFor(c => c.IdadeFinal)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido");
        }

    }
}
