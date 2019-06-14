using AutoMapper;
using Protectos.Application.Interfaces.Entidades;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Application.ViewModels.Entidades;
using Protectos.Domain.Entities.Entidades;
using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Domain.Entities.Entidades.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ApplicationServices.Entidades
{
    public class EntidadeApplicationService : ApplicationService, IEntidadeApplicationService
    {
        private readonly IEntidadeRepository _entidadeRepository;
        private readonly IEntidadeEmailRepository _entidadeEmailRepository;
        private readonly IEntidadeTelefoneRepository _entidadeTelefoneRepository;
        private readonly IEntidadeEnderecoRepository _entidadeEndrecoRepository;
        private readonly IEntidadeService _entidadeService;
        public EntidadeApplicationService(IEntidadeRepository entidadeRepository,
            IEntidadeEmailRepository entidadeEmailRepository,
            IEntidadeTelefoneRepository entidadeTelefoneRepository,
            IEntidadeEnderecoRepository entidadeEndrecoRepository,
            IEntidadeService entidadeService, IUnitOfWork uow) : base(uow)
        {
            _entidadeRepository = entidadeRepository;
            _entidadeEmailRepository = entidadeEmailRepository;
            _entidadeTelefoneRepository = entidadeTelefoneRepository;
            _entidadeEndrecoRepository = entidadeEndrecoRepository;
            _entidadeService = entidadeService;
        }
        public EntidadeViewModel EntidadeAdicionar(EntidadeViewModel entidadeViewModel)
        {
            var entidade = Mapper.Map<Entidade>(entidadeViewModel);
            _entidadeService.EntidadeAdicionar(entidade);
            Commit();
            return entidadeViewModel;
        }
        public EntidadeViewModel EntidadeAtualizar(EntidadeViewModel entidadeViewModel)
        {
            var entidade = Mapper.Map<Entidade>(entidadeViewModel);
            _entidadeService.EntidadeAtualizar(entidade);
            Commit();
            return entidadeViewModel;
        }
        public EntidadeEmailViewModel EntidadeEmailAdicionar(EntidadeEmailViewModel entidadeEmailViewModel)
        {
            var entidade = Mapper.Map<EntidadeEmail>(entidadeEmailViewModel);
            _entidadeService.EntidadeEmailAdicionar(entidade);
            Commit();
            return entidadeEmailViewModel;
        }
        public EntidadeEmailViewModel EntidadeEmailAtualizar(EntidadeEmailViewModel entidadeEmailViewModel)
        {
            var entidade = Mapper.Map<EntidadeEmail>(entidadeEmailViewModel);
            _entidadeService.EntidadeEmailAtualizar(entidade);
            Commit();
            return entidadeEmailViewModel;
        }
        public EntidadeEnderecoViewModel EntidadeEnderecoAdicionar(EntidadeEnderecoViewModel entidadeEnderecoViewModel)
        {
            var entidade = Mapper.Map<EntidadeEndereco>(entidadeEnderecoViewModel);
            _entidadeService.EntidadeEnderecoAdicionar(entidade);
            Commit();
            return entidadeEnderecoViewModel;
        }
        public EntidadeEnderecoViewModel EntidadeEnderecoAtualizar(EntidadeEnderecoViewModel entidadeEnderecoViewModel)
        {
            var entidade = Mapper.Map<EntidadeEndereco>(entidadeEnderecoViewModel);
            _entidadeService.EntidadeEnderecoAtualizar(entidade);
            Commit();
            return entidadeEnderecoViewModel;
        }
        public EntidadeTelefoneViewModel EntidadeTelefoneAdicionar(EntidadeTelefoneViewModel entidadeTelefoneViewModel)
        {
            var entidade = Mapper.Map<EntidadeTelefone>(entidadeTelefoneViewModel);
            _entidadeService.EntidadeTelefoneAdicionar(entidade);
            Commit();
            return entidadeTelefoneViewModel;
        }
        public EntidadeTelefoneViewModel EntidadeTelefoneAtualizar(EntidadeTelefoneViewModel entidadeTelefoneViewModel)
        {
            var entidade = Mapper.Map<EntidadeTelefone>(entidadeTelefoneViewModel);
            _entidadeService.EntidadeTelefoneAtualizar(entidade);
            Commit();
            return entidadeTelefoneViewModel;
        }
        public void DeleteEntidade(Guid id)
        {
            _entidadeService.DeleteEntidade(id);
        }
        public void DeleteEntidadeEmail(Guid id)
        {
            _entidadeService.DeleteEntidadeEmail(id);
        }
        public void DeleteEntidadeEndereco(Guid id)
        {
            _entidadeService.DeleteEntidadeEndereco(id);
        }
        public void DeleteEntidadeTelefone(Guid id)
        {
            _entidadeService.DeleteEntidadeTelefone(id);
        }
        public IEnumerable<EntidadeEmailViewModel> EntidadeEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<EntidadeEmailViewModel>>(_entidadeEmailRepository.GetAll());
        }
        public IEnumerable<EntidadeEnderecoViewModel> EntidadeEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<EntidadeEnderecoViewModel>>(_entidadeEndrecoRepository.GetAll());
        }
        

        public IEnumerable<EntidadeViewModel> EntidadeObterAtivo()
        {
            return Mapper.Map<IEnumerable<EntidadeViewModel>>(_entidadeRepository.EntidadeObterAtivo());
        }
        public IEnumerable<EntidadeViewModel> EntidadeObterInativo()
        {
            return Mapper.Map<IEnumerable<EntidadeViewModel>>(_entidadeRepository.EntidadeObterInativo());
        }
        public EntidadeViewModel EntidadeObterPorCnpj(string cnpj)
        {
            return Mapper.Map<EntidadeViewModel>(_entidadeRepository.EntidadeObterPorCnpj(cnpj));
        }
        public EntidadeViewModel EntidadeObterPorId(Guid id)
        {
            return Mapper.Map<EntidadeViewModel>(_entidadeRepository.GetbyId(id));
        }
        public IEnumerable<EntidadeViewModel> EntidadeObterTodos()
        {
            return Mapper.Map<IEnumerable<EntidadeViewModel>>(_entidadeRepository.GetAll());
        }
        public IEnumerable<EntidadeTelefoneViewModel> EntidadeTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<EntidadeTelefoneViewModel>>(_entidadeTelefoneRepository.GetAll());
        }

        public void Dispose()
        {
            _entidadeRepository.Dispose();
            _entidadeEmailRepository.Dispose();
            _entidadeTelefoneRepository.Dispose();
            _entidadeEndrecoRepository.Dispose();
            _entidadeService.Dispose();
        }

        public EntidadeEmailViewModel EntidadeEmailObterPorId(Guid id)
        {
            return Mapper.Map<EntidadeEmailViewModel>(_entidadeEmailRepository.GetbyId(id));
        }
        public EntidadeTelefoneViewModel EntidadeTelefoneObterPorId(Guid id)
        {
            return Mapper.Map<EntidadeTelefoneViewModel>(_entidadeTelefoneRepository.GetbyId(id));
        }
        public EntidadeEnderecoViewModel EntidadeEnderecoObterPorId(Guid id)
        {
            return Mapper.Map<EntidadeEnderecoViewModel>(_entidadeEndrecoRepository.GetbyId(id));
        }

    }
}
