using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Corretores
{
    public class CorretorEmail : Entity<CorretorEmail>
    {
        public CorretorEmail(string email, Guid corretorId, string tipoEmail)
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
        public string TipoEmail { get; private set; }
        public virtual Corretor Corretor { get; private set; }

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
