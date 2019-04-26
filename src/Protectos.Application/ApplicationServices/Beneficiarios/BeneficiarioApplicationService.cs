using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Application.ViewModels.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ApplicationServices.Beneficiarios
{
    public class BeneficiarioApplicationService : IBeneficiarioApplicationService
    {
        private IBeneficiarioRepository _beneficiarioRepository;
        public BeneficiarioApplicationService(IBeneficiarioRepository beneficiarioRepository)
        {
            _beneficiarioRepository = beneficiarioRepository;
        }

        public BeneficiarioViewModel Adicionar(BeneficiarioViewModel beneficiarioViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioDependenteViewModel Adicionar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioEnderecoViewModel Adicionar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioEmailViewModel Adicionar(BeneficiarioEmailViewModel beneficiarioEmailViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioTelefoneViewModel Adicionar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioViewModel Atualizar(BeneficiarioViewModel beneficiarioViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioDependenteViewModel Atualizar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioEnderecoViewModel Atualizar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioEmailViewModel Atualizar(BeneficiarioEmailViewModel beneficiarioEmailViewModel)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioTelefoneViewModel Atualizar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioEnderecoViewModel> BeneficiarioEnderecoObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioViewModel> BeneficiarioObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioTelefoneViewModel> BeneficiarioTelefoneObterTodos()
        {
            throw new NotImplementedException();
        }

        public void deleteBeneficiarioEmailViewModel()
        {
            throw new NotImplementedException();
        }

        public BeneficiarioDependenteViewModel ObterBenediciarioDependentePorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioViewModel> ObterBeneficiarioAtivo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioDependenteViewModel> ObterBeneficiarioDependenteAtivo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioDependenteViewModel> ObterBeneficiarioDependenteInativo()
        {
            throw new NotImplementedException();
        }

        public BeneficiarioDependenteViewModel ObterBeneficiarioDependentePorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioEmailViewModel> ObterBeneficiarioEmailTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BeneficiarioViewModel> ObterBeneficiarioInativo()
        {
            throw new NotImplementedException();
        }

        public BeneficiarioViewModel ObterBeneficiarioPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public BeneficiarioViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
