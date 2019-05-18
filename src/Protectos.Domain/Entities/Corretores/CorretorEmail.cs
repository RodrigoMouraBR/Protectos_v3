using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Corretores
{
    public class CorretorEmail : Entity<CorretorEmail>
    {
        public CorretorEmail(string email, Guid corretorId, ETipoEmail tipoEmail)
        {
            Email = email;
            CorretorId = corretorId;
            TipoEmail = tipoEmail;
        }
        protected CorretorEmail()
        {
        }
        public string Email { get; private set; }
        public Guid CorretorId { get; private set; }
        public ETipoEmail TipoEmail { get; private set; }
        public virtual Corretor Corretor { get; private set; }
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
