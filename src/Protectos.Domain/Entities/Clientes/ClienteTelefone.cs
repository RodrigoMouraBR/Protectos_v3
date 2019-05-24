﻿using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Clientes
{
    public class ClienteTelefone : Entity<ClienteTelefone>
    {
        public ClienteTelefone(string prefixo, string numero, ETipoTelefoneEmpresa tipoTelefone, Guid clienteId)
        {
            Prefixo = prefixo;
            Numero = numero;
            TipoTelefone = tipoTelefone;
            ClienteId = clienteId;
        }
        protected ClienteTelefone()
        {
        }
        public string Prefixo { get; private set; }
        public string Numero { get; private set; }
        public ETipoTelefoneEmpresa TipoTelefone { get; private set; }
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
            RuleFor(c => c.Prefixo)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 5).WithMessage("o telefone precisa ter entre 2 e 5 caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");

            RuleFor(s => s.TipoTelefone)
                .NotEmpty()
                .WithMessage("É necessário um tipo de telefone");
        }

    }
}
