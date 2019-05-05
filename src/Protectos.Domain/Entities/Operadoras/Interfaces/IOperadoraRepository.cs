using Protectos.Domain.Generics.Interfaces;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Operadoras.Interfaces
{
    public interface IOperadoraRepository : IRepository<Operadora>
    {
        Operadora OperadoraObterPorCnpj(string cnpj);
        IEnumerable<Operadora> OperadoraObterAtivo();
        IEnumerable<Operadora> OperadoraObterInativo();
    }
}
