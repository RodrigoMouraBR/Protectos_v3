using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Propostas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Cobrancas
{
    public class MotivoExclusao : Entity<MotivoExclusao>
    {
        public virtual ICollection<Proposta> Proposta { get; private set; }
        public override bool IsValid()
        {
            
            throw new NotImplementedException();
        }
    }
}
