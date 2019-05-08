using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;

namespace Protectos.Infra.Data.Repositories.Entidades
{
    public class EntidadeTelefoneRepository : Repository<EntidadeTelefone>, IEntidadeTelefoneRepository
    {
        public EntidadeTelefoneRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
    }
}
