using FluentValidation;
using Protectos.Domain.Core.Models;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Administradoras
{
    public class Administradora : Entity<Administradora>
    {
        public Administradora()
        {           
            Enderecos = new List<AdministradoraEndereco>();
            Telefones = new List<AdministradoraTelefone>();
            Emails = new List<AdministradoraEmail>();
        }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        public DateTime DataCadastro { get; set; }

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