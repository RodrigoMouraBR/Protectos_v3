using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Beneficiarios
{
    public class BeneficiarioEnderecoRepository : Repository<BeneficiarioEndereco>, IBeneficiarioEnderecoRepository
    {
        public BeneficiarioEnderecoRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
    }
}
