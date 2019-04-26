using System.Collections.Generic;
using System.Linq;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Operadoras
{
    public class OperadoraRepository : Repository<Operadora>, IOperadoraRepository
    {
        public OperadoraRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
        public IEnumerable<Operadora> OperadoraObterAtivo()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Operadora> OperadoraObterInativo()
        {
            throw new System.NotImplementedException();
        }
        public Operadora OperadoraObterPorCpf(string cnpj)
        {
            return Search(c => c.Empresa.Cnpj.Numero == cnpj).FirstOrDefault();
        }
    }
}
