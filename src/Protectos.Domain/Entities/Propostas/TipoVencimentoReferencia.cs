using Protectos.Domain.Core.Models;
using System;

namespace Protectos.Domain.Entities.Propostas
{
    public class TipoVencimentoReferencia : Entity<TipoVencimentoReferencia>
    {
        public TipoVencimentoReferencia(string descricao, string vigencia)
        {
            Descricao = descricao;
            Vigencia = vigencia;
        }
        public string Descricao { get; private set; }
        public string Vigencia { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
