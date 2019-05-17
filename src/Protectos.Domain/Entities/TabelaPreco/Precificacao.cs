using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Planos;
using Protectos.Domain.Generics.Enums;
using System;
namespace Protectos.Domain.Entities.TabelaPreco
{
    public class Precificacao : Entity<Precificacao>
    {
        public Guid PLanoId { get; private set; }
        public Guid FaturaId { get; private set; }
        public int IdadeInicial { get; private set; }
        public int IdadeFinal { get; private set; }
        public Decimal ValorPlanoTitular { get; private set; }
        public Decimal ValorPlanoDependente { get; set; }
        public Decimal ValorPlanoAgregado { get; private set; }
        public Decimal ValorPlanoTitularNet { get; private set; }
        public Decimal ValorPlanoDependenteNet { get; set; }
        public Decimal ValorPlanoAgregadoNet { get; private set; }        
        public DateTime DataInicio { get; private set; }
        public Decimal ValorPorcentagemPFP { get; private set; }
        public EStatus Status { get; private set; }
        public virtual Plano Plano { get; private set; }
        public virtual Fatura Fatura { get; private set; }
        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
