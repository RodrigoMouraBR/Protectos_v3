using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
using System;

namespace Protectos.Domain.Entities.Operadoras
{
    public class OperadoraEndereco : Entity<OperadoraEndereco>
    {
        public OperadoraEndereco(Endereco endereco, Guid operadoraId)
        {
            Endereco = endereco;
            OperadoraId = operadoraId;
        }
        protected OperadoraEndereco()
        {

        }
        public Endereco Endereco { get; private set; }
        public Guid OperadoraId { get; private set; }
        public virtual Operadora Operadora { get; private set; }
        public override bool IsValid()
        {
            Validation();
            return ValidationResult.IsValid;
        }
        private void Validation()
        {
            ValidationProperties();
            ValidationResult = Validate(this);
        }
        private void ValidationProperties()
        {
            RuleFor(c => c.Endereco.Logradouro)
                .NotEmpty().WithMessage("O endereço precisa ser fornecido")
                .Length(2, 150).WithMessage("O endereço precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Endereco.Numero)
                .NotEmpty().WithMessage("O número precisa ser fornecido")
                .Length(1, 10).WithMessage("O número precisa ter entre 2 e 2 caracteres");
            RuleFor(c => c.Endereco.Bairro)
                .NotEmpty().WithMessage("O bairro precisa ser fornecido")
                .Length(3, 50).WithMessage("O bairro precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Endereco.Cep)
                .NotEmpty().WithMessage("O cep precisa ser fornecido")
                .Length(8).WithMessage("O cep precisa ter 8 caracteres");
            RuleFor(c => c.Endereco.Cidade)
                .NotEmpty().WithMessage("A cidade precisa ser fornecido")
                .Length(3, 50).WithMessage("A cidade precisa ter entre 3 e 50 caracteres");
            RuleFor(c => c.Endereco.Estado)
                .NotEmpty().WithMessage("O estado precisa ser fornecido")
                .Length(3, 50).WithMessage("O estado precisa ter entre 3 e 50 caracteres");
            RuleFor(c => c.Endereco.UF)
                .NotEmpty().WithMessage("O UF precisa ser fornecido")
                .Length(2).WithMessage("O UF precisa ter 2 caracteres");
            RuleFor(c => c.Endereco.Pais)
                .NotEmpty().WithMessage("O pais precisa ser fornecido")
                .Length(3, 50).WithMessage("O pais precisa ter entre 2 e 50 caracteres");
        }
    }
}
