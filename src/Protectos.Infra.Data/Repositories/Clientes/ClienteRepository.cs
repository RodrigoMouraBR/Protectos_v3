using Protectos.Domain.Entities.Clientes;
using Protectos.Domain.Entities.Clientes.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Infra.Data.Repositories.Clientes
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<Cliente> ClienteObterAtivo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ClienteObterInativo()
        {
            throw new NotImplementedException();
        }

        public Cliente ClienteObterPorCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}
