﻿using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Entidades
{
    public class EntidadeTelefone : Entity<EntidadeTelefone>
    {
        public EntidadeTelefone(string prefixo, string numero, ETipoTelefoneEmpresa tipoTelefone, Guid entidadeId)
        {
            Prefixo = prefixo;
            Numero = numero;
            TipoTelefone = tipoTelefone;
            EntidadeId = entidadeId;
        }
        protected EntidadeTelefone()
        {
        }
        public string Prefixo { get; private set; }
        public string Numero { get;private  set; }
        public ETipoTelefoneEmpresa TipoTelefone { get;private  set; }
        public Guid EntidadeId { get;private  set; }
        public virtual Entidade Entidade { get; private set; }
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
            RuleFor(c => c.Prefixo)
                .NotEmpty().WithMessage("O prefixo precisa ser fornecido")
                .Length(2, 5).WithMessage("O prefixo precisa ter entre 2 e 5 caracteres");
            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("O numero precisa ser fornecido")
                .Length(9, 10).WithMessage("O numero precisa ter entre 9 e 10 caracteres");
            RuleFor(c => c.TipoTelefone)
                .NotEmpty().WithMessage("O Tipo telefone precisa ser fornecido");
        }
    }
}
