using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Clientes;
using Protectos.Domain.Entities.Propostas;
using Protectos.Domain.Generics.Enums;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Beneficiarios
{
    public class Beneficiario : Entity<Beneficiario>
    {
        public Beneficiario(string nome, string sobrenome, DateTime dataNascimento, ESexo sexo, string cpf, string rG, DateTime dataEmissaoRG, string orgaoEmissor, EEstadoCivil estadoCivil)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Cpf = cpf;
            RG = rG;
            DataEmissaoRG = dataEmissaoRG;
            OrgaoEmissor = orgaoEmissor;
            EstadoCivil = estadoCivil;
            Enderecos = new List<BeneficiarioEndereco>();
            Telefones = new List<BeneficiarioTelefone>();
            Emails = new List<BeneficiarioEmail>();
            Propostas = new List<Proposta>();
            Dependentes = new List<BeneficiarioDependente>();
        }
        protected Beneficiario()
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
        public virtual ICollection<BeneficiarioEndereco> Enderecos { get; private set; }
        public virtual ICollection<BeneficiarioTelefone> Telefones { get; private set; }
        public virtual ICollection<BeneficiarioEmail> Emails { get; private set; }        
        public virtual ICollection<Proposta> Propostas { get; private set; }
        public virtual ICollection<BeneficiarioDependente> Dependentes { get; private set; }

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
