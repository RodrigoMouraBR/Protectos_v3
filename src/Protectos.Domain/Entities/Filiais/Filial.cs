﻿using FluentValidation;
using Protectos.Domain.Core.Models;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Filiais
{
    public class Filial : Entity<Filial>
    {
        public Filial(string razaoSocial, 
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
        }
        protected Filial()
        {
        }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }
        public virtual ICollection<FilialEndereco> Enderecos { get; private set; }
        public virtual ICollection<FilialTelefone> Telefones { get; private set; }
        public virtual ICollection<FilialEmail> Emails { get; private set; }

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


    }
}
