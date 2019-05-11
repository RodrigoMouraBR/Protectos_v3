using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System.Collections.Generic;
using System.Linq;
namespace Protectos.Infra.Data.Repositories.Corretoras
{
    public class CorretoraRepository : Repository<Corretora>, ICorretoraRepository
    {
        public CorretoraRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<Corretora> CorretoraObterAtivo()
        {
            return Search(c => c.Ativo == true).ToList();
        }
        public IEnumerable<Corretora> CorretoraObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
        }
        public Corretora CorretoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Cnpj == cnpj).FirstOrDefault();
        }
    }
}
