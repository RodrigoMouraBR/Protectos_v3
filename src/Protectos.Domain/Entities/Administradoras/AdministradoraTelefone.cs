using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Administradoras
{
    public class AdministradoraTelefone : Entity<AdministradoraTelefone>
    {


        public string Prefixo { get; set; }
        public string Numero { get; set; }
        public ETipoTelefoneEmpresa TipoTelefone { get; set; }
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
            RuleFor(c => c.Prefixo)
                .NotEmpty().WithMessage("O prefixo precisa ser fornecido")
                .Length(2, 5).WithMessage("O prefixo precisa ter entre 2 e 5 caracteres");
            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("O numero precisa ser fornecido")
                .Length(9, 10).WithMessage("O numero precisa ter entre 9 e 10 caracteres");
            RuleFor(c => c.TipoTelefone)
                .NotEmpty().WithMessage("O Tipo telefone precisa ser fornecido");
        }
    }
}
