using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Generics.Enums;
using System;

namespace Protectos.Domain.Entities.Configuracoes
{
    public class RelacaoOperadoraEntidade : Entity<RelacaoOperadoraEntidade>
    {
        public Guid EntidadeId { get; private set; }
        public Guid OperadoraId { get; private set; }
        public virtual Entidade Entidades { get; private set; }
        public virtual Operadora Operadoras { get; private set; }
        public EStatus Status { get; private set; }        

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
