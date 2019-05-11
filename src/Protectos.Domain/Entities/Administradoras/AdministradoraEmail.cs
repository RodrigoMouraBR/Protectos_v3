using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Administradoras
{
    public class AdministradoraEmail : Entity<AdministradoraEmail>
    {

        public string Email { get; set; }
        public ETipoEmailEmpresa TipoEmail { get; set; }
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
            RuleFor(s => s.Email).NotEmpty().WithMessage("É necessário um endereço de e-mail")
                     .EmailAddress().WithMessage("Um e-mail válido é obrigatório");
            RuleFor(s => s.TipoEmail).NotEmpty().WithMessage("É necessário um tipo de e-mail");
        }
    }
}
