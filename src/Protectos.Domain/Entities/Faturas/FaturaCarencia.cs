using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Faturas
{
    public class FaturaCarencia : Entity<FaturaCarencia>
    {
        public FaturaCarencia(string numeroFaturaCarencia, 
                                string descricao, 
                                EStatus status, 
                                Guid faturaId)
        {
            this.numeroFaturaCarencia = numeroFaturaCarencia;
            Descricao = descricao;
            Status = status;
            FaturaId = faturaId;
        }
        public string numeroFaturaCarencia { get; private set; }
        public string Descricao { get; private set; }
        public EStatus Status { get; private set; }        
        public Guid FaturaId { get; private set; }
        public virtual Fatura Fatura { get; private set; }
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
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 100).WithMessage("o telefone precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.numeroFaturaCarencia)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");
        }

    }
}
