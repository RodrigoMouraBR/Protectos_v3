using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Propostas;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Cobrancas
{
    public class Banco : Entity<Banco>
    {
        public Banco(string numeroBanco, string descricaoBanco)
        {
            NumeroBanco = numeroBanco;
            DescricaoBanco = descricaoBanco;
        }
        protected Banco()
        {
        }
        public string NumeroBanco { get; private set; }
        public string DescricaoBanco { get; private set; }
        public virtual ICollection<Proposta> Propostas { get; private set; }
        public virtual ICollection<BancoAgencia> BancoAgencia { get; private set; }

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
            RuleFor(c => c.NumeroBanco)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.DescricaoBanco)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 50).WithMessage("o telefone precisa ter entre 2 e 50 caracteres");
        }
    }
}
