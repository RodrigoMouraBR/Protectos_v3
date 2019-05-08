using Protectos.Domain.Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Domain.Entities.Entidades.Interfaces.Repositories
{
    public interface IEntidadeRepository : IRepository<Entidade>
    {
        Entidade EntidadeObterPorCnpj(string cnpj);
        IEnumerable<Entidade> EntidadeObterAtivo();
        IEnumerable<Entidade> EntidadeObterInativo();
    }
}
