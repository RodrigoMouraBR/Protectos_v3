using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Operadoras
{
    public class OperadoraEmail : Entity<OperadoraEmail>
    {
        public OperadoraEmail(string email, ETipoEmailEmpresa tipoEmail, Guid operadoraId)
        {
            Email = email;
            TipoEmail = tipoEmail;
            OperadoraId = operadoraId;
        }
        protected OperadoraEmail()
        {

        }
        public string Email { get; private set; }        
        public ETipoEmailEmpresa TipoEmail { get; private set; }
        public Guid OperadoraId { get; private set; }
        public virtual Operadora Operadora { get; private set; }

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
