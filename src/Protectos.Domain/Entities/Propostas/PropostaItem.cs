using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Cobrancas;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Entities.Planos;
using Protectos.Domain.Entities.Propostas.Enums;
using System;
namespace Protectos.Domain.Entities.Propostas
{
    public class PropostaItem : Entity<PropostaItem>
    {
        public PropostaItem(Guid propostaId, 
                            Guid propostaFilhaId, 
                            Guid planoId, 
                            Guid faturaId, 
                            Guid faturaSubprodutoId, 
                            Guid beneficiarioId, 
                            EPropostaItemStatus propostaItemStatus, 
                            Guid motivoExclusaoId, 
                            DateTime dataVigencia, 
                            Guid operadoraCongenereId, 
                            Guid faturaCarenciaId)
        {
            PropostaId = propostaId;
            PropostaFilhaId = propostaFilhaId;
            PlanoId = planoId;
            FaturaId = faturaId;
            FaturaSubprodutoId = faturaSubprodutoId;
            BeneficiarioId = beneficiarioId;
            PropostaItemStatus = propostaItemStatus;
            MotivoExclusaoId = motivoExclusaoId;
            DataVigencia = dataVigencia;
            OperadoraCongenereId = operadoraCongenereId;
            FaturaCarenciaId = faturaCarenciaId;
        }
        public Guid PropostaId { get; private set; }
        public Guid PropostaFilhaId { get; private set; }
        public Guid PlanoId { get; private set; }
        public Guid FaturaId { get; private set; }
        public Guid FaturaSubprodutoId { get; private set; }
        public Guid BeneficiarioId { get; private set; }
        public EPropostaItemStatus PropostaItemStatus { get; private set; }
        public Guid MotivoExclusaoId { get; private set; }
        public DateTime DataVigencia { get; private set; }
        public Guid OperadoraCongenereId { get; private set; }
        public Guid FaturaCarenciaId { get; private set; }
        //public virtual Plano Plano { get; private set; }
        //public virtual Fatura Fatura { get; private set; }
        //public virtual Beneficiario Beneficiario { get; private set; }
        //public virtual MotivoExclusao MotivoExclusao { get; private set; }
        //public virtual FaturaCarencia FaturaCarencia { get; private set; }
        //public virtual OperadoraCongenere OperadoraCongenere { get; private set; }

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
            RuleFor(c => c.PropostaItemStatus)
                .NotEmpty().WithMessage("a proposta status precisa ser fornecido");                
        }

    }
}
