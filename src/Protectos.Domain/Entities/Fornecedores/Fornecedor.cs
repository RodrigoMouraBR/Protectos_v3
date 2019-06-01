using FluentValidation;
using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
namespace Protectos.Domain.Entities.Fornecedores
{
    public class Fornecedor : Entity<Fornecedor>
    {
        public Fornecedor(string razaoSocial, string nomeFantasia, string inscricaoEstadual, string inscricaoMunicipal, string cnpjNumero, string site)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Site = site;
            AtribuirCnpj(cnpjNumero);
        }

        protected Fornecedor() { }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public string Site { get; private set; }
        public CNPJ CNPJ { get; private set; }       
        public bool AtribuirCnpj(string cnpjNumero)
        {
            var cnpj = new CNPJ(cnpjNumero);
            if (!cnpj.Validar())
                return false;
            CNPJ = cnpj;
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
