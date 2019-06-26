using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Entidades
{
    public class EntidadeTelefone : Entity<EntidadeTelefone>
    {
        public EntidadeTelefone(string prefixo, string numero, string tipoTelefone, Guid entidadeId)
        {
            Prefixo = prefixo;
            Numero = numero;
            TipoTelefone = tipoTelefone;
            EntidadeId = entidadeId;
        }
        protected EntidadeTelefone()
        {
        }
        public string Prefixo { get; private set; }
        public string Numero { get;private  set; }
        public string TipoTelefone { get;private  set; }
        public Guid EntidadeId { get;private  set; }
        public virtual Entidade Entidade { get; private set; }

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
            RuleFor(c => c.Prefixo)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 5).WithMessage("o telefone precisa ter entre 2 e 5 caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");

            RuleFor(s => s.TipoTelefone)
                .NotEmpty()
                .WithMessage("É necessário um tipo de telefone");
        }

    }
}
