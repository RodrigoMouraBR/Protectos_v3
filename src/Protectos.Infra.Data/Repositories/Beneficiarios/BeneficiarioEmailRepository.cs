using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Beneficiarios
{
    public class BeneficiarioEmailRepository : Repository<BeneficiarioEmail>, IBeneficiarioEmailRepository
    {
        public BeneficiarioEmailRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
    }
}
