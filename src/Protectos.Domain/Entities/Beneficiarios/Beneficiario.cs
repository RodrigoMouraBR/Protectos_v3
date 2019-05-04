using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using Protectos.Domain.ValuesObjects;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Beneficiarios
{
    public class Beneficiario : Entity<Beneficiario>
    {
        public Beneficiario(string nome, string sobrenome, DateTime dataNascimento,
                             ESexo sexo, CPF cpf, string rG,
                             string orgaoEmissor,
                             EEstadoCivil estadoCivil,
                             bool ativo
                             )
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Cpf = cpf;
            RG = rG;
            OrgaoEmissor = orgaoEmissor;
            EstadoCivil = estadoCivil;
            Ativo = ativo;
        }
        protected Beneficiario()
        {
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public ESexo Sexo { get; private set; }
        public CPF Cpf { get; private set; }
        public string RG { get; private set; }
        public string OrgaoEmissor { get; private set; }
        public EEstadoCivil EstadoCivil { get; private set; }
        public bool Ativo { get; private set; }
        public virtual ICollection<BeneficiarioEndereco> Enderecos { get; private set; }
        public virtual ICollection<BeneficiarioTelefone> Telefones { get; private set; }
        public virtual ICollection<BeneficiarioEmail> Emails { get; private set; }
        public virtual ICollection<BeneficiarioDependente> Dependentes { get; private set; }
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
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do evento precisa ser fornecido")
                .Length(2, 150).WithMessage("O nome do evento precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithErrorCode("O Campo data de Nascimento � Obrigatorio!");
            RuleFor(c => c.DataNascimento)
               .GreaterThan(DateTime.Now).WithErrorCode("O Campo data de Nascimento n�o poder� ser maior que a data vigente");
            RuleFor(c => c.Sexo)
                .NotEmpty().WithMessage("O campo sexo � obrigatorio!");

            int idade = CalculaIdadeBeneficiario(DataNascimento);

            if (idade >= 8)
            {
                RuleFor(c => c.Cpf.Numero)
                    .NotEmpty().WithErrorCode("O Campo CPF � Obrigatorio!")
                    .Length(11, 11).WithMessage("O nome do evento precisa 11 caracteres");
            }

            RuleFor(c => c.RG)
                   .NotEmpty().WithErrorCode("O Campo Registro Geral � Obrigatorio!")
                   .Length(9, 11).WithMessage("O nome do evento precisa 11 caracteres");
            RuleFor(c => c.OrgaoEmissor)
                  .NotEmpty().WithErrorCode("O org�o emissor � Obrigatorio!");
            RuleFor(c => c.EstadoCivil)
                .NotEmpty().WithMessage("O campo estado civil � obrigatorio!");
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
