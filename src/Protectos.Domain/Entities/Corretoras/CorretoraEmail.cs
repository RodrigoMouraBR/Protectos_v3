using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Corretoras
{
    public class CorretoraEmail : Entity<CorretoraEmail>
    {
        public CorretoraEmail(string email, ETipoEmailEmpresa tipoEmail, Guid corretoraId)
        {
            Email = email;
            TipoEmail = tipoEmail;
            CorretoraId = corretoraId;
        }
        protected CorretoraEmail()
        {
        }
        public string Email { get; private set; }       
        public ETipoEmailEmpresa TipoEmail { get; private set; }
        public Guid CorretoraId { get; private set; }
        public virtual Corretora Corretora { get; private set; }
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
