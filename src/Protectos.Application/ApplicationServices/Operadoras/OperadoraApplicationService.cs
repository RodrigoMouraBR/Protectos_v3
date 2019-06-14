using AutoMapper;
using Protectos.Application.Interfaces.Operadoras;
using Protectos.Application.ViewModels.Operadoras;
using Protectos.Domain.Entities.Operadoras;
using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Domain.Entities.Operadoras.Interfaces.Services;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
namespace Protectos.Application.ApplicationServices.Operadoras
{
    public class OperadoraApplicationService : ApplicationService, IOperadoraApplicationService
    {
        private readonly IOperadoraRepository _OperadoraRepository;
        private readonly IOperadoraEmailRepository _OperadoraEmailRepository;
        private readonly IOperadoraTelefoneRepository _OperadoraTelefoneRepository;
        private readonly IOperadoraEnderecoRepository _OperadoraEndrecoRepository;
        private readonly IOperadoraService _OperadoraService;
        public OperadoraApplicationService(IOperadoraRepository OperadoraRepository,
                                                IOperadoraEmailRepository OperadoraEmailRepository,
                                                IOperadoraTelefoneRepository OperadoraTelefoneRepository,
                                                IOperadoraEnderecoRepository OperadoraEndrecoRepository,
                                                IOperadoraService OperadoraService,
                                                IUnitOfWork uow) : base(uow)
        {
            _OperadoraRepository = OperadoraRepository;
            _OperadoraEmailRepository = OperadoraEmailRepository;
            _OperadoraTelefoneRepository = OperadoraTelefoneRepository;
            _OperadoraEndrecoRepository = OperadoraEndrecoRepository;
            _OperadoraService = OperadoraService;
        }
        //OperadoraServices
        public OperadoraViewModel OperadoraAdicionar(OperadoraViewModel OperadoraViewModel)
        {
            var Operadora = Mapper.Map<Operadora>(OperadoraViewModel);
            _OperadoraService.OperadoraAdicionar(Operadora);
            Commit();
            return OperadoraViewModel;
        }
        public OperadoraViewModel OperadoraAtualizar(OperadoraViewModel OperadoraViewModel)
        {
            var Operadora = Mapper.Map<Operadora>(OperadoraViewModel);
            _OperadoraService.OperadoraAtualizar(Operadora);
            Commit();
            return OperadoraViewModel;
        }
        public void DeleteOperadora(Guid id)
        {
            _OperadoraService.DeleteOperadora(id);
        }
        public OperadoraEmailViewModel OperadoraEmailAdicionar(OperadoraEmailViewModel OperadoraEmailViewModel)
        {
            var OperadoraEmail = Mapper.Map<OperadoraEmail>(OperadoraEmailViewModel);
            _OperadoraService.OperadoraEmailAdicionar(OperadoraEmail);
            Commit();
            return OperadoraEmailViewModel;
        }
        public OperadoraEmailViewModel OperadoraEmailAtualizar(OperadoraEmailViewModel OperadoraEmailViewModel)
        {
            var OperadoraEmail = Mapper.Map<OperadoraEmail>(OperadoraEmailViewModel);
            _OperadoraService.OperadoraEmailAtualizar(OperadoraEmail);
            Commit();
            return OperadoraEmailViewModel;
        }
        public void DeleteOperadoraEmail(Guid id)
        {
            _OperadoraService.DeleteOperadoraEmail(id);
        }
        public OperadoraEnderecoViewModel OperadoraEnderecoAdicionar(OperadoraEnderecoViewModel OperadoraEnderecoViewModel)
        {
            var OperadoraEndereco = Mapper.Map<OperadoraEndereco>(OperadoraEnderecoViewModel);
            _OperadoraService.OperadoraEnderecoAdicionar(OperadoraEndereco);
            Commit();
            return OperadoraEnderecoViewModel;
        }
        public OperadoraEnderecoViewModel OperadoraEnderecoAtualizar(OperadoraEnderecoViewModel OperadoraEnderecoViewModel)
        {
            var OperadoraEndereco = Mapper.Map<OperadoraEndereco>(OperadoraEnderecoViewModel);
            _OperadoraService.OperadoraEnderecoAtualizar(OperadoraEndereco);
            Commit();
            return OperadoraEnderecoViewModel;
        }
        public void DeleteOperadoraEndereco(Guid id)
        {
            _OperadoraService.DeleteOperadoraEndereco(id);
        }
        public OperadoraTelefoneViewModel OperadoraTelefoneAdicionar(OperadoraTelefoneViewModel OperadoraTelefoneViewModel)
        {
            var OperadoraTelefone = Mapper.Map<OperadoraTelefone>(OperadoraTelefoneViewModel);
            _OperadoraService.OperadoraTelefoneAdicionar(OperadoraTelefone);
            Commit();
            return OperadoraTelefoneViewModel;
        }
        public OperadoraTelefoneViewModel OperadoraTelefoneAtualizar(OperadoraTelefoneViewModel OperadoraTelefoneViewModel)
        {
            var OperadoraTelefone = Mapper.Map<OperadoraTelefone>(OperadoraTelefoneViewModel);
            _OperadoraService.OperadoraTelefoneAtualizar(OperadoraTelefone);
            Commit();
            return OperadoraTelefoneViewModel;
        }
        public void DeleteOperadoraTelefone(Guid id)
        {
            _OperadoraService.DeleteOperadoraTelefone(id);
        }
        //OperadoraRepositories
        public IEnumerable<OperadoraEnderecoViewModel> OperadoraEnderecoObterTodos()
        {
            return Mapper.Map<IEnumerable<OperadoraEnderecoViewModel>>(_OperadoraEndrecoRepository.GetAll());
        }
        public IEnumerable<OperadoraTelefoneViewModel> OperadoraTelefoneObterTodos()
        {
            return Mapper.Map<IEnumerable<OperadoraTelefoneViewModel>>(_OperadoraTelefoneRepository.GetAll());
        }
        public IEnumerable<OperadoraEmailViewModel> OperadoraEmailObterTodos()
        {
            return Mapper.Map<IEnumerable<OperadoraEmailViewModel>>(_OperadoraEmailRepository.GetAll());
        }
        public IEnumerable<OperadoraViewModel> OperadoraObterTodos()
        {
            return Mapper.Map<IEnumerable<OperadoraViewModel>>(_OperadoraRepository.GetAll());
        }
        public IEnumerable<OperadoraViewModel> OperadoraObterAtivo()
        {
            return Mapper.Map<IEnumerable<OperadoraViewModel>>(_OperadoraRepository.OperadoraObterAtivo());
        }
        public IEnumerable<OperadoraViewModel> OperadoraObterInativo()
        {
            return Mapper.Map<IEnumerable<OperadoraViewModel>>(_OperadoraRepository.OperadoraObterInativo());
        }
        public OperadoraViewModel OperadoraObterPorCnpj(string cnpj)
        {
            return Mapper.Map<OperadoraViewModel>(_OperadoraRepository.OperadoraObterPorCnpj(cnpj));
        }
        public OperadoraViewModel OperadoraObterPorId(Guid id)
        {
            return Mapper.Map<OperadoraViewModel>(_OperadoraRepository.GetbyId(id));
        }

        public void Dispose()
        {
            _OperadoraRepository.Dispose();
            _OperadoraEmailRepository.Dispose();
            _OperadoraTelefoneRepository.Dispose();
            _OperadoraEndrecoRepository.Dispose();
            _OperadoraService.Dispose();
        }

        public OperadoraEnderecoViewModel EntidadeEnderecoObterPorId(Guid id)
        {
            return Mapper.Map<OperadoraEnderecoViewModel>(_OperadoraEndrecoRepository.GetbyId(id));
        }
        public OperadoraEmailViewModel EntidadeEmailObterPorId(Guid id)
        {
            return Mapper.Map<OperadoraEmailViewModel>(_OperadoraEmailRepository.GetbyId(id));
        }
        public OperadoraTelefoneViewModel EntidadeTelefoneObterPorId(Guid id)
        {
            return Mapper.Map<OperadoraTelefoneViewModel>(_OperadoraTelefoneRepository.GetbyId(id));
        }
    }
}
