using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Planos.Enums;
using System;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Planos
{
    public class Plano : Entity<Plano>
    {
        public Plano(string codigoPlano, string descricao, EPlanoTipo planoTipo, string codigoPlanoANS, string coparticipacao, string codigoAcomodacao, string codigoPlanoSuspenso)
        {
            CodigoPlano = codigoPlano;
            Descricao = descricao;
            PlanoTipo = planoTipo;
            CodigoPlanoANS = codigoPlanoANS;
            Coparticipacao = coparticipacao;
            CodigoAcomodacao = codigoAcomodacao;
            CodigoPlanoSuspenso = codigoPlanoSuspenso;
        }
        public string CodigoPlano { get; private set; }
        public string Descricao { get; private set; }
        public EPlanoTipo PlanoTipo { get; private set; }
        public string CodigoPlanoANS { get; private set; }
        public string Coparticipacao { get; private set; }
        public string CodigoAcomodacao { get; set; }
        public string CodigoPlanoSuspenso { get; private set; }
        public virtual ICollection<FaturaPlano> FaturaPlano { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
