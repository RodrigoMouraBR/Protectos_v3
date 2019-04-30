using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Operadoras
{
    public class Operadora : Entity<Operadora>
    {
        public Operadora(Empresa empresa)
        {
            Empresa = empresa;
        }
        protected Operadora()
        {

        }
        public Empresa Empresa { get; private set; }       
        public virtual ICollection<OperadoraEndereco> Enderecos { get; private set; }
        public virtual ICollection<OperadoraTelefone> Telefones { get; private set; }
        public virtual ICollection<OperadoraEmail> Emails { get; private set; }
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
            RuleFor(c => c.Empresa.RazaoSocial)
                .NotEmpty().WithMessage("a razão social precisa ser fornecido")
                .Length(2, 150).WithMessage("a razão precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Empresa.NomeFantasia)
                .NotEmpty().WithMessage("O nome fantasia precisa ser fornecido")
                .Length(2, 150).WithMessage("O nome fantasia precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Empresa.Cnpj.Numero)
                .NotEmpty().WithMessage("O cnpj precisa ser fornecido")
                .Length(14).WithMessage("O cnpj precisa ter 14 caracteres");
            RuleFor(c => c.Empresa.InscricaoEstadual)
                .NotEmpty().WithMessage("O nome fantasia precisa ser fornecido")
                .Length(2, 14).WithMessage("O nome fantasia precisa ter entre 2 e 150 caracteres");
        }
    }
}
