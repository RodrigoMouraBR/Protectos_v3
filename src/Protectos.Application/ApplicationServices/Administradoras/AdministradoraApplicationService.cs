using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Protectos.Application.ApplicationServices.Administradoras
{
    public class AdministradoraApplicationService : IAdministradoraApplicationService
    {
        private readonly IAdministradoraRepository _administradoraRepository;
        private readonly IAdministradoraService _administradoraService;
        public AdministradoraApplicationService(
                                                 IAdministradoraRepository administradoraRepository,
                                                 IAdministradoraService administradoraService
                                               )
        {
            _administradoraRepository = administradoraRepository;
            _administradoraService = administradoraService;
        }

        public AdministradoraViewModel AdministradoraAdicionar(AdministradoraViewModel administradoraViewModel)
        {
            throw new NotImplementedException();
        }
        public AdministradoraViewModel AdministradoraAtualizar(AdministradoraViewModel administradoraViewModel)
        {
            throw new NotImplementedException();
        }
        public AdministradoraEmailViewModel AdministradoraEmailAdicionar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            throw new NotImplementedException();
        }
        public AdministradoraEmailViewModel AdministradoraEmailAtualizar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AdministradoraEmailViewModel> AdministradoraEmailObterTodos()
        {
            throw new NotImplementedException();
        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoAdicionar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel)
        {
            throw new NotImplementedException();
        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoAtualizar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AdministradoraEnderecoViewModel> AdministradoraEnderecoObterTodos()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterAtivo()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterInativo()
        {
            throw new NotImplementedException();
        }
        public AdministradoraViewModel AdministradoraObterPorCpf(string cnpj)
        {
            throw new NotImplementedException();
        }
        public AdministradoraViewModel AdministradoraObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterTodos()
        {
            throw new NotImplementedException();
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneAdicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            throw new NotImplementedException();
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneAtualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AdministradoraTelefoneViewModel> AdministradoraTelefoneObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
