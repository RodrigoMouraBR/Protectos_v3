using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Interfaces;
namespace Protectos.Infra.Data.UoW
{
    public class UnitOfWOrk : IUnitOfWork
    {
        private readonly ProtectosContext _protectosContext;
        public UnitOfWOrk(ProtectosContext protectosContext)
        {
            // teste
            _protectosContext = protectosContext;
        }
        public void Commit()
        {
            _protectosContext.SaveChanges();
        }
    }
}
