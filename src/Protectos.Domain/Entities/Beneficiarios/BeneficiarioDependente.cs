using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Beneficiarios
{
    public class BeneficiarioDependente : Entity<BeneficiarioDependente>
    {
       
        protected BeneficiarioDependente()
        {
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public ESexo Sexo { get; private set; }
        public string Cpf { get; private set; }
        public string RG { get; private set; }
        public DateTime DataEmissaoRG { get; private set; }
        public string OrgaoEmissor { get; private set; }
        public EEstadoCivil EstadoCivil { get; private set; }
        public Guid BeneficiarioId { get; private set; }
        public virtual Beneficiario Beneficiarios { get; private set; }
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
            RuleFor(c => c.Nome)
                   .NotEmpty().WithMessage("O nome do evento precisa ser fornecido")
                   .Length(2, 100).WithMessage("O nome do evento precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.Sobrenome)
                   .NotEmpty().WithMessage("O nome do evento precisa ser fornecido")
                   .Length(2, 100).WithMessage("O nome do evento precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.DataNascimento)
               .NotEmpty().WithErrorCode("O Campo data de Nascimento precisa ser Obrigatorio!")
               .GreaterThan(DateTime.Now).WithErrorCode("O Campo data de Nascimento não poderá ser maior que a data vigente");

            RuleFor(c => c.Sexo)
                .NotEmpty().WithMessage("O campo sexo precisa ser fornecido");

            int idade = CalculaIdadeBeneficiario(DataNascimento);
            if (idade >= 8)
            {
                RuleFor(c => c.Cpf)
                    .NotEmpty().WithErrorCode("O Campo CPF precisa ser fornecido")
                    .Length(11).WithMessage("O nome do evento precisa 11 caracteres");
            }

            RuleFor(c => c.RG)
                   .NotEmpty().WithErrorCode("O Campo Registro Geral precisa ser fornecido")
                   .Length(9, 14).WithMessage("O nome do evento precisa 14 caracteres");

            RuleFor(c => c.DataEmissaoRG)
               .NotEmpty().WithErrorCode("O Campo emissão precisa ser Obrigatorio!")
               .GreaterThan(DateTime.Now).WithErrorCode("O Campo emissão não poderá ser maior que a data vigente");

            RuleFor(c => c.OrgaoEmissor)
                  .NotEmpty().WithErrorCode("O orgãoo emissor precisa ser fornecido");

            RuleFor(c => c.EstadoCivil)
                .NotEmpty().WithMessage("O campo estado civil precisa ser fornecido");
        }
        private int CalculaIdadeBeneficiario(DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            var ageReturn = 0;
            if (birthdate > today.AddYears(-age))
                ageReturn = age--;
            return Convert.ToInt32(ageReturn);
        }
    }
}
