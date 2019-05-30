using Protectos.Domain.Core.Models;
using Protectos.Domain.ValuesObjects;
using System;
namespace Protectos.Domain.Entities.Fornecedores
{
    public class Fornecedor : Entity<Fornecedor>
    {
        protected Fornecedor()
        {

        }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string InscricaoMunicipal { get; private set; }
        public CNPJ Cnpj { get; private set; }
        
        public string Site { get; private set; }

























        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
