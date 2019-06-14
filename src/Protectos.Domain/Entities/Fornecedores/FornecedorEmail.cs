using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Fornecedores
{
    public class FornecedorEmail : Entity<FornecedorEmail>
    {
        public FornecedorEmail(string email, ETipoEmailEmpresa tipoEmail, Guid fornecedorId)
        {
            Email = email;
            TipoEmail = tipoEmail;
            FornecedorId = FornecedorId;
        }
        protected FornecedorEmail()
        {

        }
        public string Email { get; private set; }
        public ETipoEmailEmpresa TipoEmail { get; private set; }
        public Guid FornecedorId { get; private set; }
        public virtual Fornecedor Fornecedor { get; private set; }
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
