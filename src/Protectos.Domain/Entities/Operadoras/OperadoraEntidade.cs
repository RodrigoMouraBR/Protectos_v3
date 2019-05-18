using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Entidades;
using System;
namespace Protectos.Domain.Entities.Operadoras
{
    public class OperadoraEntidade : Entity<OperadoraEntidade>
    {
        public OperadoraEntidade(Guid operadoraId, Guid entidadeId)
        {
            OperadoraId = operadoraId;
            EntidadeId = entidadeId;
        }
        protected OperadoraEntidade()
        {
        }
        public Guid OperadoraId { get; private set; }
        public Guid EntidadeId { get; private set; }
        public virtual Operadora Operadora { get; private set; }
        public virtual Entidade Entidade { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
