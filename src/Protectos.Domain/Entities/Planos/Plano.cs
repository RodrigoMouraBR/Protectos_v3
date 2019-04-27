using Protectos.Domain.Core.Models;
using Protectos.Domain.Entities.Planos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Planos
{
    public class Plano : Entity<Plano>
    {
        public string CodigoPlano { get; private set; }
        public string Descricao { get; private set; }
        public EPlanoTipo PlanoTipo { get; private set; }
        public string CodigoPlanoANS { get; private set; }
        public string Coparticipacao { get; private set; }
        public string CodigoAcomodacao { get; set; }
        public string CodigoPlanoSuspenso { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
