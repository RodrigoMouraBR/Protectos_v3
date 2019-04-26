using Protectos.Domain.Generics.Interfaces;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Corretoras.Interfaces.Repositories
{
    public interface ICorretoraRepository : IRepository<Corretora>
    {
        Corretora CorretoraObterPorCpf(string cnpj);
        IEnumerable<Corretora> CorretoraObterAtivo();
        IEnumerable<Corretora> CorretoraObterInativo();
    }
}
