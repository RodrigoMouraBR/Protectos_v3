using FluentValidation;
using Protectos.Domain.Core.Models;
using System;
namespace Protectos.Domain.Entities.Operadoras
{
    public class OperadoraCongenere : Entity<OperadoraCongenere>
    {
        public OperadoraCongenere(string descricao, Guid operadoraId)
        {
            Descricao = descricao;
            OperadoraId = operadoraId;
        }
        protected OperadoraCongenere()
        {
        }
        public string Descricao { get; private set; }
        public Guid OperadoraId { get; private set; }
        public virtual Operadora Operadora { get; private set; }

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
                .Length(2, 100).WithMessage("o telefone precisa ter entre 2 e 100 caracteres");           
        }
    }
}
