using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
using System;
namespace Protectos.Domain.Entities.Administradoras
{
    public class AdministradoraEndereco : Entity<AdministradoraEndereco>
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public Guid AdministradoraId { get; set; }
        public virtual Administradora Administradora { get; set; }
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
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("O endereço precisa ser fornecido")
                .Length(2, 150).WithMessage("O endereço precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("O número precisa ser fornecido")
                .Length(1, 10).WithMessage("O número precisa ter entre 2 e 2 caracteres");
            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("O bairro precisa ser fornecido")
                .Length(3, 50).WithMessage("O bairro precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Cep)
                .NotEmpty().WithMessage("O cep precisa ser fornecido")
                .Length(8).WithMessage("O cep precisa ter 8 caracteres");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("A cidade precisa ser fornecido")
                .Length(3, 50).WithMessage("A cidade precisa ter entre 3 e 50 caracteres");
            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("O estado precisa ser fornecido")
                .Length(3, 50).WithMessage("O estado precisa ter entre 3 e 50 caracteres");
            RuleFor(c => c.UF)
                .NotEmpty().WithMessage("O UF precisa ser fornecido")
                .Length(2).WithMessage("O UF precisa ter 2 caracteres");
            RuleFor(c => c.Pais)
                .NotEmpty().WithMessage("O pais precisa ser fornecido")
                .Length(3, 50).WithMessage("O pais precisa ter entre 2 e 50 caracteres");
        }
    }
}