using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Protectos.Infra.Data.Repositories.Entidades
{
    public class EntidadeRepository : Repository<Entidade>, IEntidadeRepository
    {
        public EntidadeRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<Entidade> AdministradoraObterAtivo()
        {
            return Search(c => c.Ativo == true).ToList();
        }
        public IEnumerable<Entidade> AdministradoraObterInativo()
        {
            return Search(c => c.Ativo == false).ToList();
        }
        public Entidade AdministradoraObterPorCnpj(string cnpj)
        {
            return Search(c => c.Empresa.Cnpj.Numero == cnpj).FirstOrDefault();
        }
    }
}
