using Protectos.Application.ViewModels.Beneficiarios;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Beneficiarios
{
    public interface IBeneficiarioApplicationService
    {
        //BeneFiciario
        BeneficiarioViewModel ObterPorId(Guid id);
        BeneficiarioViewModel ObterBeneficiarioPorCpf(string cpf);
        IEnumerable<BeneficiarioViewModel> BeneficiarioObterTodos();
        IEnumerable<BeneficiarioViewModel> ObterBeneficiarioAtivo();
        IEnumerable<BeneficiarioViewModel> ObterBeneficiarioInativo();
        BeneficiarioViewModel Adicionar(BeneficiarioViewModel beneficiarioViewModel);
        BeneficiarioViewModel Atualizar(BeneficiarioViewModel beneficiarioViewModel);         

        //Dependente
        BeneficiarioDependenteViewModel ObterBenediciarioDependentePorId(Guid id);
        BeneficiarioDependenteViewModel ObterBeneficiarioDependentePorCpf(string cpf);
        IEnumerable<BeneficiarioDependenteViewModel> BeneficiarioDependenteObterTodos();
        IEnumerable<BeneficiarioDependenteViewModel> ObterBeneficiarioDependenteAtivo();
        IEnumerable<BeneficiarioDependenteViewModel> ObterBeneficiarioDependenteInativo();
        BeneficiarioDependenteViewModel Adicionar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel);
        BeneficiarioDependenteViewModel Atualizar(BeneficiarioDependenteViewModel beneficiarioDependenteViewModel);       

        //Endereco        
        IEnumerable<BeneficiarioEnderecoViewModel> BeneficiarioEnderecoObterTodos();
        BeneficiarioEnderecoViewModel Adicionar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel);
        BeneficiarioEnderecoViewModel Atualizar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel);
        
        //Email      
        IEnumerable<BeneficiarioEmailViewModel> ObterBeneficiarioEmailTodos();
        BeneficiarioEmailViewModel Adicionar(BeneficiarioEmailViewModel beneficiarioEmailViewModel);
        BeneficiarioEmailViewModel Atualizar(BeneficiarioEmailViewModel beneficiarioEmailViewModel);
        void deleteBeneficiarioEmailViewModel();
        //Telefone     
        IEnumerable<BeneficiarioTelefoneViewModel> BeneficiarioTelefoneObterTodos();
        BeneficiarioTelefoneViewModel Adicionar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel);
        BeneficiarioTelefoneViewModel Atualizar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel);
        
    }
}
