using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Propostas;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Cobrancas
{
    public class MotivoExclusao : Entity<MotivoExclusao>
    {
        public Guid  OperadoraId { get; private set; }
        public string CodigoMotivoExclusao { get; private set; }
        public string Descricao { get; private set; }
        public virtual ICollection<Proposta> Propostas { get; private set; }
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
            RuleFor(c => c.CodigoMotivoExclusao)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");            
        }
    }
}
