using FluentValidation;
using Protectos.Domain.Core.Models;
using System;
namespace Protectos.Domain.Entities.Filiais
{
    public class FilialEndereco : Entity<FilialEndereco>
    {
        public FilialEndereco(string logradouro, string numero, string bairro, string cep, string complemento, string cidade, string estado, string uF, string pais, Guid filialId)
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
            FilialId = filialId;
        }
        protected FilialEndereco()
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
        public Guid FilialId { get; private set; }
        public virtual Filial Filial { get; private set; }
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
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("O endereço precisa ser fornecido")
                .Length(2, 150).WithMessage("O endereço precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("O número precisa ser fornecido")
                .Length(1, 10).WithMessage("O número precisa ter entre 2 e 2 caracteres");
            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("O bairro precisa ser fornecido")
                .Length(3, 50).WithMessage("O bairro precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Cep)
                .NotEmpty().WithMessage("O cep precisa ser fornecido")
                .Length(8).WithMessage("O cep precisa ter 8 caracteres");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("A cidade precisa ser fornecido")
                .Length(3, 50).WithMessage("A cidade precisa ter entre 3 e 50 caracteres");
            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("O estado precisa ser fornecido")
                .Length(3, 50).WithMessage("O estado precisa ter entre 3 e 50 caracteres");
            RuleFor(c => c.UF)
                .NotEmpty().WithMessage("O UF precisa ser fornecido")
                .Length(2).WithMessage("O UF precisa ter 2 caracteres");
            RuleFor(c => c.Pais)
                .NotEmpty().WithMessage("O pais precisa ser fornecido")
                .Length(3, 50).WithMessage("O pais precisa ter entre 2 e 50 caracteres");
        }
    }
}
