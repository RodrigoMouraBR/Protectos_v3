using AutoMapper;
using Protectos.Application.Interfaces.Corretoras;
using Protectos.Application.ViewModels.Corretoras;
using Protectos.Domain.Entities.Corretoras;
using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Corretoras.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
namespace Protectos.Application.ApplicationServices.Corretoras
{
    public class CorretoraApplicationService : ApplicationService, ICorretoraApplicationService
    {
        private readonly ICorretoraRepository _corretoraRepository;
        private readonly ICorretoraEmailRepository _corretoraEmailRepository;
        private readonly ICorretoraTelefoneRepository _corretoraTelefoneRepository;
        private readonly ICorretoraEnderecoRepository _corretoraEndrecoRepository;
        private readonly ICorretoraService _corretoraService;
        public CorretoraApplicationService(ICorretoraRepository corretoraRepository, 
            ICorretoraEmailRepository corretoraEmailRepository, 
            ICorretoraTelefoneRepository corretoraTelefoneRepository, 
            ICorretoraEnderecoRepository corretoraEndrecoRepository, 
            ICorretoraService corretoraService, IUnitOfWork uow) : base(uow)
        {
            _corretoraRepository = corretoraRepository;
            _corretoraEmailRepository = corretoraEmailRepository;
            _corretoraTelefoneRepository = corretoraTelefoneRepository;
            _corretoraEndrecoRepository = corretoraEndrecoRepository;
            _corretoraService = corretoraService;
        }
        public CorretoraViewModel CorretoraAdicionar(CorretoraViewModel corretoraViewModel)
        {
            var corretora = Mapper.Map<Corretora>(corretoraViewModel);
            _corretoraService.CorretoraAdicionar(corretora);
            Commit();
            return corretoraViewModel;
        }
        public CorretoraViewModel CorretoraAtualizar(CorretoraViewModel corretoraViewModel)
        {
            var corretora = Mapper.Map<Corretora>(corretoraViewModel);
            _corretoraService.CorretoraAtualizar(corretora);
            Commit();
            return corretoraViewModel;
        }
        public CorretoraEmailViewModel CorretoraEmailAdicionar(CorretoraEmailViewModel corretoraEmailViewModel)
        {
            var corretora = Mapper.Map<CorretoraEmail>(corretoraEmailViewModel);
            _corretoraService.CorretoraEmailAdicionar(corretora);
            Commit();
            return corretoraEmailViewModel;
        }
        public CorretoraEmailViewModel CorretoraEmailAtualizar(CorretoraEmailViewModel corretoraEmailViewModel)
        {
            var corretora = Mapper.Map<CorretoraEmail>(corretoraEmailViewModel);
            _corretoraService.CorretoraEmailAtualizar(corretora);
            Commit();
            return corretoraEmailViewModel;
        }       
        public CorretoraEnderecoViewModel CorretoraEnderecoAdicionar(CorretoraEnderecoViewModel corretoraEnderecoViewModel)
        {
            var corretora = Mapper.Map<CorretoraEndereco>(corretoraEnderecoViewModel);
            _corretoraService.CorretoraEnderecoAdicionar(corretora);
            Commit();
            return corretoraEnderecoViewModel;
        }
        public CorretoraEnderecoViewModel CorretoraEnderecoAtualizar(CorretoraEnderecoViewModel corretoraEnderecoViewModel)
        {
            var corretora = Mapper.Map<CorretoraEndereco>(corretoraEnderecoViewModel);
            _corretoraService.CorretoraEnderecoAtualizar(corretora);
            Commit();
            return corretoraEnderecoViewModel;
        }
        public CorretoraTelefoneViewModel CorretoraTelefoneAdicionar(CorretoraTelefoneViewModel corretoraTelefoneViewModel)
        {
            var corretora = Mapper.Map<CorretoraTelefone>(corretoraTelefoneViewModel);
            _corretoraService.CorretoraTelefoneAdicionar(corretora);
            Commit();
            return corretoraTelefoneViewModel;
        }
        public CorretoraTelefoneViewModel CorretoraTelefoneAtualizar(CorretoraTelefoneViewModel corretoraTelefoneViewModel)
        {
            var corretora = Mapper.Map<CorretoraTelefone>(corretoraTelefoneViewModel);
            _corretoraService.CorretoraTelefoneAtualizar(corretora);
            Commit();
            return corretoraTelefoneViewModel;
        }
        public void DeleteCorretora(Guid id)
        {
            _corretoraService.DeleteCorretora(id);
        }
        public void DeleteCorretoraEmail(Guid id)
        {
            _corretoraService.DeleteCorretoraEmail(id);
        }
        public void DeleteCorretoraEndereco(Guid id)
        {
            _corretoraService.DeleteCorretoraEndereco(id);
        }
        public void DeleteCorretoraTelefone(Guid id)
        {
            _corretoraService.DeleteCorretoraTelefone(id);
        }
        public IEnumerable<CorretoraEmailViewModel> CorretoraEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraEmailViewModel>>(_corretoraEmailRepository.GetAll());
        }
        public IEnumerable<CorretoraEnderecoViewModel> CorretoraEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraEnderecoViewModel>>(_corretoraEndrecoRepository.GetAll());
        }
        public IEnumerable<CorretoraViewModel> CorretoraObterAtivo()
        {
            return Mapper.Map<IEnumerable<CorretoraViewModel>>(_corretoraRepository.CorretoraObterAtivo());
        }
        public IEnumerable<CorretoraViewModel> CorretoraObterInativo()
        {
            return Mapper.Map<IEnumerable<CorretoraViewModel>>(_corretoraRepository.CorretoraObterInativo());
        }
        public CorretoraViewModel CorretoraObterPorCnpj(string cnpj)
        {
            return Mapper.Map<CorretoraViewModel>(_corretoraRepository.CorretoraObterPorCnpj(cnpj));
        }
        public CorretoraViewModel CorretoraObterPorId(Guid id)
        {
            return Mapper.Map<CorretoraViewModel>(_corretoraRepository.GetbyId(id));
        }
        public IEnumerable<CorretoraViewModel> CorretoraObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraViewModel>>(_corretoraRepository.GetAll());
        }  
        public IEnumerable<CorretoraTelefoneViewModel> CorretoraTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<CorretoraTelefoneViewModel>>(_corretoraTelefoneRepository.GetAll());
        }

        public void Dispose()
        {
            _corretoraRepository.Dispose();
            _corretoraEmailRepository.Dispose();
            _corretoraTelefoneRepository.Dispose();
            _corretoraEndrecoRepository.Dispose();            
            _corretoraService.Dispose();
        }
    }
}
