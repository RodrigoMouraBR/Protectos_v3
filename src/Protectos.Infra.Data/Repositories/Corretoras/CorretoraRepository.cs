using System.Collections.Generic;
using System.Linq;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Corretoras
{
    public class CorretoraRepository : Repository<Corretora>, ICorretoraRepository
    {
        public CorretoraRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
        public IEnumerable<Corretora> CorretoraObterAtivo()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Corretora> CorretoraObterInativo()
        {
            throw new System.NotImplementedException();
        }
        public Corretora CorretoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Empresa.Cnpj.Numero == cnpj).FirstOrDefault();
        }
    }
}
