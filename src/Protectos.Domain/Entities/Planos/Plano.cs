using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Cobrancas;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Planos.Enums;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Planos
{
    public class Plano : Entity<Plano>
    {
        public Plano(string codigoPlano, string descricao, EPlanoTipo planoTipo, string codigoPlanoANS, string coparticipacao, string codigoAcomodacao, string codigoPlanoSuspenso)
        {
            CodigoPlano = codigoPlano;
            Descricao = descricao;
            PlanoTipo = planoTipo;
            CodigoPlanoANS = codigoPlanoANS;
            Coparticipacao = coparticipacao;
            CodigoAcomodacao = codigoAcomodacao;
            CodigoPlanoSuspenso = codigoPlanoSuspenso;
        }
        public string CodigoPlano { get; private set; }
        public string Descricao { get; private set; }
        public EPlanoTipo PlanoTipo { get; private set; }
        public string CodigoPlanoANS { get; private set; }
        public string Coparticipacao { get; private set; }
        public string CodigoAcomodacao { get; set; }
        public string CodigoPlanoSuspenso { get; private set; }
        public virtual ICollection<FaturaPlano> FaturaPlano { get; private set; }
        public virtual ICollection<Precificacao> Precificacao { get; private set; }

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
            RuleFor(c => c.CodigoPlanoANS)
                .NotEmpty().WithMessage("o codigo do plano ANS precisa ser fornecido")
                .Length(1, 10).WithMessage("o codigo do plano ANS precisa ter entre 1 e 10 caracteres");

            RuleFor(c => c.Coparticipacao)
                .NotEmpty().WithMessage("a Coparticipação precisa ser fornecido")
                .Length(1, 10).WithMessage("a Coparticipação precisa ter entre 1 e 10 caracteres");

            RuleFor(c => c.CodigoAcomodacao)
                .NotEmpty().WithMessage("o Codigo Acomodação precisa ser fornecido")
                .Length(1, 10).WithMessage("o Codigo Acomodação precisa ter entre 1 e 10 caracteres");

            RuleFor(c => c.CodigoPlanoSuspenso)
                .NotEmpty().WithMessage("o codigo plano suspenso precisa ser fornecido")
                .Length(1, 10).WithMessage("o codigo plano suspenso precisa ter entre 1 e 10 caracteres");


            RuleFor(c => c.CodigoPlano)
                .NotEmpty().WithMessage("o codigo plano precisa ser fornecido")
                .Length(1, 10).WithMessage("o codigo plano precisa ter entre 1 e 10 caracteres");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("a descrição precisa ser fornecido")
                .Length(2, 100).WithMessage("a descrição precisa ter entre 2 e 100 caracteres");

            RuleFor(s => s.PlanoTipo)
                .NotEmpty()
                .WithMessage("É necessário um tipo de telefone");
        }
    }
}
