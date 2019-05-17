using Protectos.Domain.Entities.Planos;
using Protectos.Domain.Entities.Planos.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Planos
{
    public class PlanoRepository : Repository<Plano>, IPlanoRepository
    {
        public PlanoRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
    }
}
