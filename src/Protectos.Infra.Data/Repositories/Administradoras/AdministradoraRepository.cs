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
            throw new System.NotImplementedException();
        }
        public IEnumerable<Administradora> AdministradoraObterInativo()
        {
            throw new System.NotImplementedException();
        }
        public Administradora AdministradoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Empresa.Cnpj.Numero == cnpj).FirstOrDefault();
        }
    }
}
