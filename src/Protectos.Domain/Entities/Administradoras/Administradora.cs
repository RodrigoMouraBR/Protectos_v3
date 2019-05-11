using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Administradoras
{
    public class Administradora : Entity<Administradora>
    {
        public Administradora(string razaoSocial,
                                string nomeFantasia, string cnpj,
                                string inscricaoEstadual,
                                string inscricaoMunicipal,
                                string site,
                                DateTime dataCadastro)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Site = site;
            DataCadastro = dataCadastro;
        }
        protected Administradora()
        {

        }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public virtual ICollection<AdministradoraEndereco> Enderecos { get; set; }
        public virtual ICollection<AdministradoraTelefone> Telefones { get; set; }
        public virtual ICollection<AdministradoraEmail> Emails { get; set; }        

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
            RuleFor(c => c.RazaoSocial)
                .NotEmpty().WithMessage("a razão social precisa ser fornecido")
                .Length(2, 150).WithMessage("a razão precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.NomeFantasia)
                .NotEmpty().WithMessage("O nome fantasia precisa ser fornecido")
                .Length(2, 150).WithMessage("O nome fantasia precisa ter entre 2 e 150 caracteres");
            RuleFor(c => c.Cnpj)
                .NotEmpty().WithMessage("O cnpj precisa ser fornecido")
                .Length(14).WithMessage("O cnpj precisa ter 14 caracteres");
            RuleFor(c => c.InscricaoEstadual)
                .NotEmpty().WithMessage("O nome fantasia precisa ser fornecido")
                .Length(2, 14).WithMessage("O nome fantasia precisa ter entre 2 e 150 caracteres");
        }
    }
}