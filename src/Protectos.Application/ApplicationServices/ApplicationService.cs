using Protectos.Infra.Data.Interfaces;
namespace Protectos.Application.ApplicationServices
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _uow;
        public ApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        protected void Commit()
        {
            _uow.Commit();
        }
    }
}
