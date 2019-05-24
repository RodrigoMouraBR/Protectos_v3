using FluentValidation;
using Protectos.Domain.Core.Models;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Administradoras
{
    public class Administradora : Entity<Administradora>
    {
        public Administradora(string razaoSocial,
                              string nomeFantasia,
                              string cnpj,
                              string inscricaoEstadual,
                              string inscricaoMunicipal,
                              string site)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Site = site;
            Enderecos = new List<AdministradoraEndereco>();
            Telefones = new List<AdministradoraTelefone>();
            Emails = new List<AdministradoraEmail>();
        }
        protected Administradora() { }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }       
        public virtual ICollection<AdministradoraEndereco> Enderecos { get; private set; }
        public virtual ICollection<AdministradoraTelefone> Telefones { get; private set; }
        public virtual ICollection<AdministradoraEmail> Emails { get; private set; }
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
                .NotEmpty().WithMessage("A raz�o social precisa ser fornecido")
                .Length(2, 100).WithMessage("A raz�o social precisa ter entre 2 e 100 caracteres");

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
    }
}