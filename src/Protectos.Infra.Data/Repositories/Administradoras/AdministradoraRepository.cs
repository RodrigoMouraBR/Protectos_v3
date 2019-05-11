using System.Collections.Generic;
using System.Linq;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Administradoras
{
    public class AdministradoraRepository : Repository<Administradora>, IAdministradoraRepository
    {
        public AdministradoraRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
        public IEnumerable<Administradora> AdministradoraObterAtivo()
        {
            return Search(c => c.Ativo == true).ToList();
        }
        public IEnumerable<Administradora> AdministradoraObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
        }
        public Administradora AdministradoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Cnpj == cnpj).FirstOrDefault();
        }
    }
}
