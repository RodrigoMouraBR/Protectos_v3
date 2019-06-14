using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.ValuesObjects;
using System;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Operadoras
{
    public class Operadora : Entity<Operadora>
    {
        public Operadora(string razaoSocial, string nomeFantasia, string cnpj, string inscricaoEstadual, string inscricaoMunicipal, string site)
        {
            AtribuirCnpj(cnpj);
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Site = site;
            Enderecos = new List<OperadoraEndereco>();
            Telefones = new List<OperadoraTelefone>();
            Emails = new List<OperadoraEmail>();
        }
        protected Operadora()
        {
        }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }       
        public virtual ICollection<OperadoraEndereco> Enderecos { get; private set; }
        public virtual ICollection<OperadoraTelefone> Telefones { get; private set; }
        public virtual ICollection<OperadoraEmail> Emails { get; private set; }        
        public virtual ICollection<Fatura> Faturas { get; private set; }
        public virtual ICollection<OperadoraCongenere> OperadoraCongeneres { get; private set; }
        public virtual ICollection<OperadoraEntidade> OperadoraEntidade { get; private set; }
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
            RuleFor(c => c.RazaoSocial)
                .NotEmpty().WithMessage("A razão social precisa ser fornecido")
                .Length(2, 100).WithMessage("A razão social precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.NomeFantasia)
                .NotEmpty().WithMessage("O nome fantasia precisa ser fornecido")
                .Length(2, 100).WithMessage("O nome fantasia precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.Cnpj)
                .NotEmpty().WithMessage("O cnpj precisa ser fornecido")
                .Length(14).WithMessage("O cnpj precisa ter 14 caracteres");

            RuleFor(c => c.InscricaoEstadual)
                .NotEmpty().WithMessage("O nome do evento precisa ser fornecido")
                .Length(2, 14).WithMessage("O nome do evento precisa ter 14 caracteres");

            RuleFor(c => c.InscricaoMunicipal)
                .NotEmpty().WithMessage("O nome do evento precisa ser fornecido")
                .Length(2, 14).WithMessage("O nome do evento precisa ter entre 2 e 150 caracteres");
        }
        private bool AtribuirCnpj(string cnpjNumero)
        {
            var cnpj = new CNPJ(cnpjNumero);
            if (!cnpj.Validar())
            {
                RuleFor(c => c.Cnpj)
                  .Equal(c => c.Cnpj).WithMessage("O número do CNPJ é Inválido");
                return false;
            }
            else
            {
                Cnpj = cnpj.Numero;
            }
            return true;
        }
    }
}
