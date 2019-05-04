using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
namespace Protectos.Domain.Entities.Administradoras.Services
{
    public class AdministradoraService : IAdministradoraService
    {
        private readonly IAdministradoraRepository _administradoraRepository;
        public AdministradoraService(IAdministradoraRepository administradoraRepository)
        {
            _administradoraRepository = administradoraRepository;
        }
        public Administradora AdministradoraAdicionar(Administradora administradora)
        {
            if (!administradora.IsValid())
                return administradora;
            _administradoraRepository.Add(administradora);
            return administradora;
        }
        public Administradora AdministradoraAtualizar(Administradora administradora)
        {
            return _administradoraRepository.Update(administradora);
        }
    }
}