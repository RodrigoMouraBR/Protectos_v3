using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
using System;

namespace Protectos.Domain.Entities.Operadoras
{
    public class OperadoraEndereco : Entity<OperadoraEndereco>
    {
        public OperadoraEndereco(string logradouro, string numero, string bairro, string cep, string complemento, string cidade, string estado, string uF, string pais, Guid operadoraId)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            UF = uF;
            Pais = pais;
            OperadoraId = operadoraId;
        }

        protected OperadoraEndereco()
        {

        }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string UF { get; private set; }
        public string Pais { get; private set; }
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
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("o logradouro precisa ser fornecido")
                .Length(2, 100).WithMessage("o logradouro precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("o bairro precisa ser fornecido")
                .Length(2, 50).WithMessage("o bairro precisa ter entre 2 e 50 caracteres");

            RuleFor(c => c.Cep)
                .NotEmpty().WithMessage("o cep precisa ser fornecido")
                .Length(2, 10).WithMessage("o cep precisa ter entre 2 e 10 caracteres");

            RuleFor(c => c.Complemento)
               .NotEmpty().WithMessage("o complemento precisa ser fornecido")
               .Length(1, 100).WithMessage("o complemento precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.Cidade)
               .NotEmpty().WithMessage("o cidade precisa ser fornecido")
               .Length(1, 50).WithMessage("o cidade precisa ter entre 2 e 50 caracteres");

            RuleFor(c => c.Estado)
               .NotEmpty().WithMessage("o estado precisa ser fornecido")
               .Length(1, 50).WithMessage("o estado precisa ter entre 2 e 50 caracteres");

            RuleFor(c => c.UF)
               .NotEmpty().WithMessage("a UF precisa ser fornecido")
               .Length(2).WithMessage("a UF precisa ter 2 caracteres");

            RuleFor(c => c.Pais)
               .NotEmpty().WithMessage("a pais precisa ser fornecido")
               .Length(2, 50).WithMessage("a pais precisa ter 2 caracteres");
        }

    }
}
