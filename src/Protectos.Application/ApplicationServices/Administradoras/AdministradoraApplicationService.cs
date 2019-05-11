﻿using AutoMapper;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Domain.Entities.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
namespace Protectos.Application.ApplicationServices.Administradoras
{
    public class AdministradoraApplicationService : ApplicationService, IAdministradoraApplicationService
    {
        private readonly IAdministradoraRepository _administradoraRepository;
        private readonly IAdministradoraEmailRepository _administradoraEmailRepository;
        private readonly IAdministradoraTelefoneRepository _administradoraTelefoneRepository;
        private readonly IAdministradoraEnderecoRepository _administradoraEndrecoRepository;        
        private readonly IAdministradoraService _administradoraService;
        public AdministradoraApplicationService(IAdministradoraRepository administradoraRepository, 
                                                IAdministradoraEmailRepository administradoraEmailRepository, 
                                                IAdministradoraTelefoneRepository administradoraTelefoneRepository, 
                                                IAdministradoraEnderecoRepository administradoraEndrecoRepository, 
                                                IAdministradoraService administradoraService,
                                                IUnitOfWork uow) : base(uow)
        {
            _administradoraRepository = administradoraRepository;
            _administradoraEmailRepository = administradoraEmailRepository;
            _administradoraTelefoneRepository = administradoraTelefoneRepository;
            _administradoraEndrecoRepository = administradoraEndrecoRepository;
            _administradoraService = administradoraService;
        }       

        //AdministradoraServices
        public AdministradoraViewModel AdministradoraAdicionar(AdministradoraViewModel administradoraViewModel)
        {
            var administradora = Mapper.Map<Administradora>(administradoraViewModel);
            _administradoraService.AdministradoraAdicionar(administradora);
            Commit();
            return administradoraViewModel;
        }
        public AdministradoraViewModel AdministradoraAtualizar(AdministradoraViewModel administradoraViewModel)
        {
            var administradora = Mapper.Map<Administradora>(administradoraViewModel);
            _administradoraService.AdministradoraAtualizar(administradora);
            Commit();
            return administradoraViewModel;
        }
        public void DeleteAdministradora(Guid id)
        {
            _administradoraService.DeleteAdministradora(id);
        }
        public AdministradoraEmailViewModel AdministradoraEmailAdicionar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            var administradoraEmail = Mapper.Map<AdministradoraEmail>(administradoraEmailViewModel);
            _administradoraService.AdministradoraEmailAdicionar(administradoraEmail);
            Commit();
            return administradoraEmailViewModel;
        }
        public AdministradoraEmailViewModel AdministradoraEmailAtualizar(AdministradoraEmailViewModel administradoraEmailViewModel)
        {
            var administradoraEmail = Mapper.Map<AdministradoraEmail>(administradoraEmailViewModel);
            _administradoraService.AdministradoraEmailAtualizar(administradoraEmail);
            Commit();
            return administradoraEmailViewModel;
        }      
        public void DeleteAdministradoraEmail(Guid id)
        {
            _administradoraService.DeleteAdministradoraEmail(id);
        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoAdicionar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel)
        {
            var administradoraEndereco = Mapper.Map<AdministradoraEndereco>(administradoraEnderecoViewModel);
            _administradoraService.AdministradoraEnderecoAdicionar(administradoraEndereco);
            Commit();
            return administradoraEnderecoViewModel;
        }
        public AdministradoraEnderecoViewModel AdministradoraEnderecoAtualizar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel)
        {
            var administradoraEndereco = Mapper.Map<AdministradoraEndereco>(administradoraEnderecoViewModel);
            _administradoraService.AdministradoraEnderecoAtualizar(administradoraEndereco);
            Commit();
            return administradoraEnderecoViewModel;
        }
        public void DeleteAdministradoraEndereco(Guid id)
        {
            _administradoraService.DeleteAdministradoraEndereco(id);
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneAdicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            var administradoraTelefone = Mapper.Map<AdministradoraTelefone>(administradoraTelefoneViewModel);
            _administradoraService.AdministradoraTelefoneAdicionar(administradoraTelefone);
            Commit();
            return administradoraTelefoneViewModel;
        }
        public AdministradoraTelefoneViewModel AdministradoraTelefoneAtualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel)
        {
            var administradoraTelefone = Mapper.Map<AdministradoraTelefone>(administradoraTelefoneViewModel);
            _administradoraService.AdministradoraTelefoneAtualizar(administradoraTelefone);
            Commit();
            return administradoraTelefoneViewModel;
        }
        public void DeleteAdministradoraTelefone(Guid id)
        {
            _administradoraService.DeleteAdministradoraTelefone(id);
        }

        //AdministradoraRepositories
        public IEnumerable<AdministradoraEnderecoViewModel> AdministradoraEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraEnderecoViewModel>>(_administradoraEndrecoRepository.GetAll());
        }
        public IEnumerable<AdministradoraTelefoneViewModel> AdministradoraTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraTelefoneViewModel>>(_administradoraTelefoneRepository.GetAll());
        }
        public IEnumerable<AdministradoraEmailViewModel> AdministradoraEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraEmailViewModel>>(_administradoraEmailRepository.GetAll());
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterTodos()
        {
            return Mapper.Map<IEnumerable<AdministradoraViewModel>>(_administradoraRepository.GetAll());
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterAtivo()
        {
            return Mapper.Map<IEnumerable<AdministradoraViewModel>>(_administradoraRepository.AdministradoraObterAtivo());
        }
        public IEnumerable<AdministradoraViewModel> AdministradoraObterInativo()
        {
            return Mapper.Map<IEnumerable<AdministradoraViewModel>>(_administradoraRepository.AdministradoraObterInativo());
        }
        public AdministradoraViewModel AdministradoraObterPorCnpj(string cnpj)
        {
            return Mapper.Map<AdministradoraViewModel>(_administradoraRepository.AdministradoraObterPorCnpj(cnpj));
        }
        public AdministradoraViewModel AdministradoraObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraViewModel>(_administradoraRepository.GetbyId(id));
        }
        public void Dispose()
        {
            _administradoraRepository.Dispose();
            _administradoraEmailRepository.Dispose();
            _administradoraTelefoneRepository.Dispose();
            _administradoraEndrecoRepository.Dispose();
            _administradoraService.Dispose();
        }

        public AdministradoraEnderecoViewModel AdministradoraEnderecoObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraEnderecoViewModel>(_administradoraEndrecoRepository.GetbyId(id));
        }

        public AdministradoraEmailViewModel AdministradoraEmailObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraEmailViewModel>(_administradoraEmailRepository.GetbyId(id));
        }

        public AdministradoraTelefoneViewModel AdministradoraTelefoneObterPorId(Guid id)
        {
            return Mapper.Map<AdministradoraTelefoneViewModel>(_administradoraTelefoneRepository.GetbyId(id));
        }
    }
}
