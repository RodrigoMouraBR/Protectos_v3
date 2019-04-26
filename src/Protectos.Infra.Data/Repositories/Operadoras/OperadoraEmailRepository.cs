using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;

namespace Protectos.Infra.Data.Repositories.Operadoras
{
    public class OperadoraEmailRepository : Repository<OperadoraEmail>, IOperadoraEmailRepository
    {
        public OperadoraEmailRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
    }
}
