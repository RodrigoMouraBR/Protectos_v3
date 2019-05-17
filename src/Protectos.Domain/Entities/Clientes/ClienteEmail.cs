using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Clientes
{
    public class ClienteEmail : Entity<ClienteEmail>
    {
        public ClienteEmail(string email, ETipoEmailEmpresa tipoEmail, Guid clienteId)
        {
            Email = email;
            TipoEmail = tipoEmail;
            ClienteId = clienteId;
        }
        protected ClienteEmail()
        {

        }
        public string Email { get; private set; }
        public ETipoEmailEmpresa TipoEmail { get; private set; }
        public Guid ClienteId { get; private set; }
        public virtual Cliente Cliente { get; private set; }

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
