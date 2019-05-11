using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Protectos.Infra.Data.Repositories.Entidades
{
    public class EntidadeRepository : Repository<Entidade>, IEntidadeRepository
    {
        public EntidadeRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<Entidade> EntidadeObterAtivo()
        {
            return Search(c => c.Ativo == true).ToList();
        }
        public IEnumerable<Entidade> EntidadeObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
        }
        public Entidade EntidadeObterPorCnpj(string cnpj)
        {
            return Search(c => c.Cnpj == cnpj).FirstOrDefault();
        }
    }
}
