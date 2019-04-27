using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Faturas
{
    public class FaturaCarencia : Entity<FaturaCarencia>
    {
        public string numeroFaturaCarencia { get; private set; }
        public string Descricao { get; private set; }
        public EStatus Status { get; private set; }
        public virtual Guid FaturaId { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
