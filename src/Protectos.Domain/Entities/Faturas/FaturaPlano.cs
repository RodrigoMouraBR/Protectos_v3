using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Planos;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Faturas
{
    public class FaturaPlano : Entity<FaturaPlano>
    {
        public Guid FaturaId { get; private set; }
        public Guid PlanoId { get; private set; }
        public bool TitularPlano { get; private set; }
        public bool DependentePlano { get; private set; }
        public bool AgregadoPlano { get; private set; }
        public EStatus Status { get; private set; }
        public virtual Fatura Faturas { get; private set; }
        public virtual Plano Planos { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
