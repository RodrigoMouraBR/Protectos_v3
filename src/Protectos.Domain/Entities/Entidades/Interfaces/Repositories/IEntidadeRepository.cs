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
        Entidade AdministradoraObterPorCnpj(string cnpj);
        IEnumerable<Entidade> AdministradoraObterAtivo();
        IEnumerable<Entidade> AdministradoraObterInativo();
    }
}
