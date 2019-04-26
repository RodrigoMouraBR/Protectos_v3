using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Administradoras
{
    public class AdministradoraEnderecoRepository : Repository<AdministradoraEndereco>, IAdministradoraEnderecoRepository
    {
        public AdministradoraEnderecoRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
    }
}
