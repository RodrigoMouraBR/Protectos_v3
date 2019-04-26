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

        public AdministradoraViewModel Adicionar(AdministradoraViewModel beneficiarioViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraEnderecoViewModel Adicionar(AdministradoraEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraEmailViewModel Adicionar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraTelefoneViewModel Adicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraViewModel Atualizar(AdministradoraViewModel beneficiarioViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraEnderecoViewModel Atualizar(AdministradoraEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraEmailViewModel Atualizar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            throw new NotImplementedException();
        }

        public AdministradoraTelefoneViewModel Atualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministradoraTelefoneViewModel> BeneficiarioTelefoneObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministradoraEmailViewModel> ObterAdministradoraEmailTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministradoraViewModel> ObterBeneficiarioAtivo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministradoraEnderecoViewModel> ObterBeneficiarioEnderecoTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministradoraViewModel> ObterBeneficiarioInativo()
        {
            throw new NotImplementedException();
        }

        public AdministradoraViewModel ObterBeneficiarioPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public AdministradoraViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministradoraViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
