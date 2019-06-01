using Dapper;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System.Collections.Generic;
using System.Linq;
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
            //var sql = @"select * from Administradora a where a.ativo = 1";
            //return _protectosContext.Database.Connection.Query<Administradora>(sql);
        }
        public IEnumerable<Administradora> AdministradoraObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
            //var sql = @"SELECT * FROM Administradora a WHERE a.Ativo = 0";
            //return _protectosContext.Database.Connection.Query<Administradora>(sql);
        }
        public Administradora AdministradoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Cnpj.Numero == cnpj).FirstOrDefault();
        }
    }
}
