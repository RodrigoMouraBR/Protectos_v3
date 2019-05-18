using Protectos.Domain.Core.Models;
using System;
namespace Protectos.Domain.Entities.Operadoras
{
    public class OperadoraCongenere : Entity<OperadoraCongenere>
    {
        public OperadoraCongenere(string descricao, Guid operadoraId)
        {
            Descricao = descricao;
            OperadoraId = operadoraId;
        }
        protected OperadoraCongenere()
        {
        }
        public string Descricao { get; private set; }
        public Guid OperadoraId { get; private set; }
        public virtual Operadora Operadora { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
