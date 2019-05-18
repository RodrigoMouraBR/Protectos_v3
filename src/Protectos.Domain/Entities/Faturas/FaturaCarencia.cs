using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.Faturas
{
    public class FaturaCarencia : Entity<FaturaCarencia>
    {
        public FaturaCarencia(string numeroFaturaCarencia, 
                                string descricao, 
                                EStatus status, 
                                Guid faturaId)
        {
            this.numeroFaturaCarencia = numeroFaturaCarencia;
            Descricao = descricao;
            Status = status;
            FaturaId = faturaId;
        }
        public string numeroFaturaCarencia { get; private set; }
        public string Descricao { get; private set; }
        public EStatus Status { get; private set; }        
        public Guid FaturaId { get; private set; }
        public virtual Fatura Fatura { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
