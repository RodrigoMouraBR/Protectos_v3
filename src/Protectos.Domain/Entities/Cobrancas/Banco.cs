using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Propostas;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Cobrancas
{
    public class Banco : Entity<Banco>
    {
        public Banco(string numeroBanco, string descricaoBanco)
        {
            NumeroBanco = numeroBanco;
            DescricaoBanco = descricaoBanco;
        }
        protected Banco()
        {
        }
        public string NumeroBanco { get; private set; }
        public string DescricaoBanco { get; private set; }
        public virtual ICollection<Proposta> Proposta { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
