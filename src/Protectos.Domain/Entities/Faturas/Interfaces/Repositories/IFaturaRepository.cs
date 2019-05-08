using Protectos.Domain.Generics.Interfaces;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Faturas.Interfaces.Repositories
{
    public interface IFaturaRepository : IRepository<Fatura>
    {
        Fatura FaturaObterPorNumero(string numeroFatura);
        IEnumerable<Fatura> FaturaObterAtivo();
        IEnumerable<Fatura> FaturaObterInativo();
    }
}
