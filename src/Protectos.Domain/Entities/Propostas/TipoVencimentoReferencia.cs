using FluentValidation;
using Protectos.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Propostas
{
    public class TipoVencimentoReferencia : Entity<TipoVencimentoReferencia>
    {
        public TipoVencimentoReferencia(string descricao, string vigencia)
        {
            Descricao = descricao;
            Vigencia = vigencia;
        }
        public string Descricao { get; private set; }
        public string Vigencia { get; private set; }
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
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 100).WithMessage("o telefone precisa ter entre 2 e 5 caracteres");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(1, 2).WithMessage("o telefone precisa ter entre 1 e 2 caracteres");
        }

    }
}
