using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;

namespace Protectos.Infra.Data.Repositories.Entidades
{
    public class EntidadeEmailRepository : Repository<EntidadeEmail>, IEntidadeEmailRepository
    {
        public EntidadeEmailRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
    }
}
