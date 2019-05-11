using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System.Collections.Generic;
using System.Linq;
namespace Protectos.Infra.Data.Repositories.Operadoras
{
    public class OperadoraRepository : Repository<Operadora>, IOperadoraRepository
    {
        public OperadoraRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
        public IEnumerable<Operadora> OperadoraObterAtivo()
        {
            return Search(c => c.Ativo == true).ToList();
        }
        public IEnumerable<Operadora> OperadoraObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
        }
        public Operadora OperadoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Cnpj == cnpj).FirstOrDefault();
        }
    }
}
