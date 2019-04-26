﻿using Protectos.Domain.Entities.Operadoras;
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
    }
}
