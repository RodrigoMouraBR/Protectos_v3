using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Clientes
{
    public class ClienteEmail : Entity<ClienteEmail>
    {
        public ClienteEmail(string email, string tipoEmail, Guid clienteId)
        {
            Email = email;
            TipoEmail = tipoEmail;
            ClienteId = clienteId;
        }
        protected ClienteEmail()
        {

        }
        public string Email { get; private set; }
        public string TipoEmail { get; private set; }
        public Guid ClienteId { get; private set; }
        public virtual Cliente Cliente { get; private set; }

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
                .NotEmpty()
                .WithMessage("É necessário um tipo de e-mail");
        }


    }
}
