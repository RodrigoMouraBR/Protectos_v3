using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Administradoras
{
    public class AdministradoraTelefone : Entity<AdministradoraTelefone>
    {
        public AdministradoraTelefone(string prefixo, string numero, string tipoTelefone, Guid administradoraId)
        {
            Prefixo = prefixo;
            Numero = numero;
            TipoTelefone = tipoTelefone;
            AdministradoraId = administradoraId;
        }
        protected AdministradoraTelefone()
        {

        }
        public string Prefixo { get; private set; }
        public string Numero { get; private set; }
        public string TipoTelefone { get; private set; }
        public Guid AdministradoraId { get; private set; }
        public virtual Administradora Administradora { get; private set; }

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
            RuleFor(c => c.Prefixo)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 5).WithMessage("o telefone precisa ter entre 2 e 5 caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("o telefone precisa ser fornecido")
                .Length(2, 10).WithMessage("o telefone precisa ter entre 2 e 10 caracteres");

            RuleFor(s => s.TipoTelefone)
                .NotEmpty().WithMessage("o tipo telefone precisa ser fornecido")
                .WithMessage("É necessário um tipo de telefone");
        }


    }
}
