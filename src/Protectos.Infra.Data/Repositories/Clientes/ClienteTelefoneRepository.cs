using Protectos.Domain.Entities.Clientes;
using Protectos.Domain.Entities.Clientes.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Clientes
{
    public class ClienteTelefoneRepository : Repository<ClienteTelefone>, IClienteTelefoneRepository
    {
        public ClienteTelefoneRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
    }
}
