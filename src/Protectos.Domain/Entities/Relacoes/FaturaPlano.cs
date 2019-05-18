using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Planos;
using System;
namespace Protectos.Domain.Entities.Relacoes
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
