using Protectos.Application.Interfaces.Fatura;
using Protectos.Application.ViewModels.Faturas;
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
            throw new NotImplementedException();
        }
        public FaturaViewModel FaturaAdicionar(FaturaViewModel faturaViewModel)
        {
            throw new NotImplementedException();
        }
        public FaturaViewModel FaturaAtualizar(FaturaViewModel faturaViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<FaturaViewModel> FaturaObterAtivo()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<FaturaViewModel> FaturaObterInativo()
        {
            throw new NotImplementedException();
        }
        public FaturaViewModel FaturaObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public FaturaViewModel FaturaObterPorNumero(string numeroFatura)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<FaturaViewModel> FaturaObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
