using AutoMapper;
using Protectos.Application.Interfaces.Fatura;
using Protectos.Application.ViewModels.Faturas;
using Protectos.Domain.Entities.Faturas;
using Protectos.Domain.Entities.Faturas.Interfaces.Interfaces.Services;
using Protectos.Domain.Entities.Faturas.Interfaces.Repositories;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
namespace Protectos.Application.ApplicationServices.Faturas
{
    public class FaturaApplicationService : ApplicationService, IFaturaApplicationService
    {
        private readonly IFaturaRepository _faturaRepository;
        private readonly IFaturaService _faturaService;
        public FaturaApplicationService(IFaturaRepository faturaRepository, 
                                        IFaturaService faturaService, 
                                        IUnitOfWork uow) : base(uow)
        {
            _faturaRepository = faturaRepository;
            _faturaService = faturaService;
        }
        public void DeleteFatura(Guid id)
        {
            _faturaService.DeleteFatura(id);
        }
        public FaturaViewModel FaturaAdicionar(FaturaViewModel faturaViewModel)
        {
            var fatura = Mapper.Map<Fatura>(faturaViewModel);
            _faturaService.FaturaAdicionar(fatura);
            Commit();
            return faturaViewModel;
        }
        public FaturaViewModel FaturaAtualizar(FaturaViewModel faturaViewModel)
        {
            var fatura = Mapper.Map<Fatura>(faturaViewModel);
            _faturaService.FaturaAtualizar(fatura);
            Commit();
            return faturaViewModel;
        }
        public IEnumerable<FaturaViewModel> FaturaObterAtivo()
        {
            return Mapper.Map<IEnumerable<FaturaViewModel>>(_faturaRepository.FaturaObterAtivo());
        }
        public IEnumerable<FaturaViewModel> FaturaObterInativo()
        {
            return Mapper.Map<IEnumerable<FaturaViewModel>>(_faturaRepository.FaturaObterInativo());
        }
        public FaturaViewModel FaturaObterPorId(Guid id)
        {
            return Mapper.Map<FaturaViewModel>(_faturaRepository.GetbyId(id));
        }
        public FaturaViewModel FaturaObterPorNumero(string numeroFatura)
        {
            return Mapper.Map<FaturaViewModel>(_faturaRepository.FaturaObterPorNumero(numeroFatura));
        }
        public IEnumerable<FaturaViewModel> FaturaObterTodos()
        {
            return Mapper.Map<IEnumerable<FaturaViewModel>>(_faturaRepository.GetAll());
        }

        public void Dispose()
        {
            _faturaRepository.Dispose();
            _faturaService.Dispose();
        }
    }
}
