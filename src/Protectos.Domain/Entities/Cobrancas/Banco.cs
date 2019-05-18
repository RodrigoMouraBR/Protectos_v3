using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Propostas;
using System;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Cobrancas
{
    public class Banco : Entity<Banco>
    {
        public virtual ICollection<Proposta> Proposta { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
