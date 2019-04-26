using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Corretoras
{
    public class CorretoraEmailRepository : Repository<CorretoraEmail>, ICorretoraEmailRepository
    {
        public CorretoraEmailRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
    }
}
