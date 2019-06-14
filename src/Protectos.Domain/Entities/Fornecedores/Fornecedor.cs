using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
namespace Protectos.Domain.Entities.Fornecedores
{
    public class Fornecedor : Entity<Fornecedor>
    {
        

        protected Fornecedor() { }

        public Fornecedor(string razaoSocial, string nomeFantasia, string inscricaoEstadual, string inscricaoMunicipal, string site, string cnpj)
        {
            AtribuirCnpj(cnpj);
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Site = site;
            Cnpj = cnpj;
        }

        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }
        public string Cnpj { get; private set; }

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
        public override bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }
        private void Validate()
        {
           
        }
       
    }
}
