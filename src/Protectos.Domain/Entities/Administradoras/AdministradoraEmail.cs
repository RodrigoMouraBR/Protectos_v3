using FluentValidation;
using Protectos.Domain.Core.Models;
using System;
namespace Protectos.Domain.Entities.Administradoras
{
    public class AdministradoraEmail : Entity<AdministradoraEmail>
    {
        public AdministradoraEmail(string email, string tipoEmail, Guid administradoraId)
        {
            Email = email;
            TipoEmail = tipoEmail;
            AdministradoraId = administradoraId;
        }
        protected AdministradoraEmail()
        {

        }
        public string Email { get; private set; }
        public string TipoEmail { get; private set; }
        public Guid AdministradoraId { get; private set; }
        public virtual Administradora Administradora { get; private set; }
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
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("o email precisa ser fornecido")
                .Length(2, 50).WithMessage("o email precisa ter entre 2 e 50 caracteres");
            RuleFor(s => s.TipoEmail)
                .NotEmpty().WithMessage("o tipo email precisa ser fornecido")
                .WithMessage("É necessário um tipo de e-mail");
        }

    }
}
