using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Planos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Faturas
{
    public class FaturaPlano : Entity<FaturaPlano>
    {
        public FaturaPlano(Guid faturaId, Guid planoId)
        {
            FaturaId = faturaId;
            PlanoId = planoId;
        }
        protected FaturaPlano()
        {
        }
        public Guid FaturaId { get; private set; }
        public Guid PlanoId { get; private set; }
        public virtual Fatura Fatura { get; private set; }
        public virtual Plano Plano { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
