using Protectos.Domain.Generics.Interfaces;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Administradoras.Interfaces.Repositories
{

    public interface IAdministradoraRepository : IRepository<Administradora>
    {
        Administradora AdministradoraObterPorCpf(string cnpj);
        IEnumerable<Administradora> AdministradoraObterAtivo();
        IEnumerable<Administradora> AdministradoraObterInativo();
    }
}