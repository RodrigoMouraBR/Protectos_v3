using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;

namespace Protectos.Infra.Data.Repositories.Entidades
{
    public class EntidadeEnderecoRepository : Repository<EntidadeEndereco>, IEntidadeEnderecoRepository
    {
        public EntidadeEnderecoRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
    }
}
