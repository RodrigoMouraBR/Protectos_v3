﻿using FluentValidation;
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
