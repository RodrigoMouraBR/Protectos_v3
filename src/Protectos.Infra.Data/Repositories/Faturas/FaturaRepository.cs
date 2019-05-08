using System.Collections.Generic;
using System.Linq;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Faturas.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Faturas
{
    public class FaturaRepository : Repository<Fatura>, IFaturaRepository
    {
        public FaturaRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<Fatura> FaturaObterAtivo()
        {
            return Search(c => c.Ativo == true).ToList();
        }
        public IEnumerable<Fatura> FaturaObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
        }
        public Fatura FaturaObterPorNumero(string numeroFatura)
        {
            return Search(c => c.NumeroFatura == numeroFatura).FirstOrDefault();
        }
    }
}
