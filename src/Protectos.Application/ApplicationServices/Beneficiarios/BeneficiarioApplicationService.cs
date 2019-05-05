using AutoMapper;
using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Application.ViewModels.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
namespace Protectos.Application.ApplicationServices.Beneficiarios
{
    public class BeneficiarioApplicationService : ApplicationService, IBeneficiarioApplicationService
    {
        private readonly IBeneficiarioRepository _beneficiarioRepository;
        private readonly IBeneficiarioDependenteRepository _beneficiarioDependenteRepository;
        private readonly IBeneficiarioEnderecoRepository _beneficiarioEnderecoRepository;
        private readonly IBeneficiarioTelefoneRepository _beneficiarioTelefoneRepository;
        private readonly IBeneficiarioEmailRepository _beneficiarioEmailRepository;
        private readonly IBeneficiarioService _beneficiarioService;

        public BeneficiarioApplicationService(IBeneficiarioRepository beneficiarioRepository,
            IBeneficiarioDependenteRepository beneficiarioDependenteRepository,
            IBeneficiarioEnderecoRepository beneficiarioEnderecoRepository,
            IBeneficiarioTelefoneRepository beneficiarioTelefoneRepository,
            IBeneficiarioEmailRepository beneficiarioEmailRepository,
            IBeneficiarioService beneficiarioService, IUnitOfWork uow) : base(uow)
        {
            _beneficiarioRepository = beneficiarioRepository;
            _beneficiarioDependenteRepository = beneficiarioDependenteRepository;
            _beneficiarioEnderecoRepository = beneficiarioEnderecoRepository;
            _beneficiarioTelefoneRepository = beneficiarioTelefoneRepository;
            _beneficiarioEmailRepository = beneficiarioEmailRepository;
            _beneficiarioService = beneficiarioService;
        }

        //Domain Service
        public BeneficiarioViewModel BeneficiarioAdicionar(BeneficiarioViewModel beneficiarioViewModel)
        {
            var beneficiario = Mapper.Map<Beneficiario>(beneficiarioViewModel);
            _beneficiarioService.BeneficiarioAdicionar(beneficiario);
            Commit();
            return beneficiarioViewModel;
        }
        public BeneficiarioViewModel BeneficiarioAtualizar(BeneficiarioViewModel beneficiarioViewModel)
        {
            var beneficiario = Mapper.Map<Beneficiario>(beneficiarioViewModel);
            _beneficiarioService.BeneficiarioAtualizar(beneficiario);
            Commit();
            return beneficiarioViewModel;
        }
        public BeneficiarioDependenteViewModel BeneficiarioDependenteAdicionar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioDependente>(beneficiarioDependenteViewModel);
            _beneficiarioService.BeneficiarioDependenteAdicionar(beneficiario);
            Commit();
            return beneficiarioDependenteViewModel;
        }
        public BeneficiarioDependenteViewModel BeneficiarioDependenteAtualizar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioDependente>(beneficiarioDependenteViewModel);
            _beneficiarioService.BeneficiarioDependenteAtualizar(beneficiario);
            Commit();
            return beneficiarioDependenteViewModel;
        }       
        public BeneficiarioEmailViewModel BeneficiarioEmailAdicionar(BeneficiarioEmailViewModel beneficiarioEmailViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioEmail>(beneficiarioEmailViewModel);
            _beneficiarioService.BeneficiarioEmailAdicionar(beneficiario);
            Commit();
            return beneficiarioEmailViewModel;
        }
        public BeneficiarioEmailViewModel BeneficiarioEmailAtualizar(BeneficiarioEmailViewModel beneficiarioEmailViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioEmail>(beneficiarioEmailViewModel);
            _beneficiarioService.BeneficiarioEmailAtualizar(beneficiario);
            Commit();
            return beneficiarioEmailViewModel;
        }       
        public BeneficiarioTelefoneViewModel BeneficiarioTelefoneAdicionar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioTelefone>(beneficiarioTelefoneViewModel);
            _beneficiarioService.BeneficiarioTelefoneAdicionar(beneficiario);
            Commit();
            return beneficiarioTelefoneViewModel;
        }
        public BeneficiarioTelefoneViewModel BeneficiarioTelefoneAtualizar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioTelefone>(beneficiarioTelefoneViewModel);
            _beneficiarioService.BeneficiarioTelefoneAtualizar(beneficiario);
            Commit();
            return beneficiarioTelefoneViewModel;
        }
        public BeneficiarioEnderecoViewModel BeneficiarioEnderecoAdicionar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioEndereco>(beneficiarioEnderecoViewModel);
            _beneficiarioService.BeneficiarioEnderecoAdicionar(beneficiario);
            Commit();
            return beneficiarioEnderecoViewModel;
        }
        public BeneficiarioEnderecoViewModel BeneficiarioEnderecoAtualizar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            var beneficiario = Mapper.Map<BeneficiarioEndereco>(beneficiarioEnderecoViewModel);
            _beneficiarioService.BeneficiarioEnderecoAtualizar(beneficiario);
            Commit();
            return beneficiarioEnderecoViewModel;
        }

        //Repository
        public IEnumerable<BeneficiarioTelefoneViewModel> BeneficiarioTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<BeneficiarioTelefoneViewModel>>(_beneficiarioTelefoneRepository.GetAll());
        }
        public IEnumerable<BeneficiarioEmailViewModel> BeneficiarioEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<BeneficiarioEmailViewModel>>(_beneficiarioEmailRepository.GetAll());
        }        
        public IEnumerable<BeneficiarioEnderecoViewModel> BeneficiarioEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<BeneficiarioEnderecoViewModel>>(_beneficiarioEnderecoRepository.GetAll());
        }
        public IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterTodos()
        {
            return Mapper.Map<IEnumerable<BeneficiarioDependenteViewModel>>(_beneficiarioDependenteRepository.GetAll());
        }
        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterTodos()
        {
            return Mapper.Map<IEnumerable<BeneficiarioViewModel>>(_beneficiarioRepository.GetAll());
        }
        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterAtivo()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterAtivo()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterInativo()
        {
            return Mapper.Map<IEnumerable<BeneficiarioViewModel>>(_beneficiarioRepository.BeneficiarioObterInativo());
        }        
        public BeneficiarioViewModel BeneficiarioObterPorCpf(string cpf)
        {
            return Mapper.Map<BeneficiarioViewModel>(_beneficiarioRepository.BeneficiarioObterPorCpf(cpf));
        }
        public BeneficiarioViewModel BeneficiarioObterPorId(Guid id)
        {
            return Mapper.Map<BeneficiarioViewModel>(_beneficiarioRepository.GetbyId(id));
        }
        public IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterInativo()
        {
            throw new NotImplementedException();
        }
        public BeneficiarioDependenteViewModel BeneficiarioDependenteObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioDependenteViewModel BeneficiarioDependenteObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
       
    }
}
