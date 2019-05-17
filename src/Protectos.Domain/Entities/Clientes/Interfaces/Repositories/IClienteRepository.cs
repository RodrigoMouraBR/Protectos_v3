using Protectos.Domain.Generics.Interfaces;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Clientes.Interfaces.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ClienteObterPorCnpj(string cnpj);
        IEnumerable<Cliente> ClienteObterAtivo();
        IEnumerable<Cliente> ClienteObterInativo();
    }
}
