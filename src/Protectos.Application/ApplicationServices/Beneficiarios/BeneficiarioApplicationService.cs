using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Application.ViewModels.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using System;
using System.Collections.Generic;
namespace Protectos.Application.ApplicationServices.Beneficiarios
{
    public class BeneficiarioApplicationService : IBeneficiarioApplicationService
    {
        private IBeneficiarioRepository _beneficiarioRepository;
        public BeneficiarioApplicationService(IBeneficiarioRepository beneficiarioRepository)
        {
            _beneficiarioRepository = beneficiarioRepository;
        }
        public BeneficiarioViewModel BeneficiarioAdicionar(BeneficiarioViewModel beneficiarioViewModel)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioViewModel BeneficiarioAtualizar(BeneficiarioViewModel beneficiarioViewModel)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioDependenteViewModel BeneficiarioDependenteAdicionar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioDependenteViewModel BeneficiarioDependenteAtualizar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterAtivo()
        {
            throw new NotImplementedException();
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
        public IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterTodos()
        {
            throw new NotImplementedException();
        }
        public BeneficiarioEmailViewModel BeneficiarioEmailAdicionar(BeneficiarioEmailViewModel beneficiarioEmailViewModel)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioEmailViewModel BeneficiarioEmailAtualizar(BeneficiarioEmailViewModel beneficiarioEmailViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioEmailViewModel> BeneficiarioEmailObterTodos()
        {
            throw new NotImplementedException();
        }
        public BeneficiarioEnderecoViewModel BeneficiarioEnderecoAdicionar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioEnderecoViewModel BeneficiarioEnderecoAtualizar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioEnderecoViewModel> BeneficiarioEnderecoObterTodos()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterAtivo()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterInativo()
        {
            throw new NotImplementedException();
        }
        public BeneficiarioViewModel BeneficiarioObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioViewModel BeneficiarioObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterTodos()
        {
            throw new NotImplementedException();
        }
        public BeneficiarioTelefoneViewModel BeneficiarioTelefoneAdicionar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel)
        {
            throw new NotImplementedException();
        }
        public BeneficiarioTelefoneViewModel BeneficiarioTelefoneAtualizar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BeneficiarioTelefoneViewModel> BeneficiarioTelefoneObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
