using Protectos.Application.ViewModels.Beneficiarios;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Beneficiarios
{
    public interface IBeneficiarioApplicationService : IDisposable
    {
        //BeneFiciario//
        BeneficiarioViewModel BeneficiarioObterPorId(Guid id);
        BeneficiarioViewModel BeneficiarioObterPorCpf(string cpf);
        IEnumerable<BeneficiarioViewModel> BeneficiarioObterTodos();
        IEnumerable<BeneficiarioViewModel> BeneficiarioObterAtivo();
        IEnumerable<BeneficiarioViewModel> BeneficiarioObterInativo();
        BeneficiarioViewModel BeneficiarioAdicionar(BeneficiarioViewModel beneficiarioViewModel);
        BeneficiarioViewModel BeneficiarioAtualizar(BeneficiarioViewModel beneficiarioViewModel);
        
        //Endereco//        
        BeneficiarioEnderecoViewModel BeneficiarioEnderecoObterPorId(Guid id);
        IEnumerable<BeneficiarioEnderecoViewModel> BeneficiarioEnderecoObterTodos();
        BeneficiarioEnderecoViewModel BeneficiarioEnderecoAdicionar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel);
        BeneficiarioEnderecoViewModel BeneficiarioEnderecoAtualizar(BeneficiarioEnderecoViewModel beneficiarioEnderecoViewModel);
        //Email//   
        BeneficiarioEmailViewModel BeneficiarioEmailObterPorId(Guid id);
        IEnumerable<BeneficiarioEmailViewModel> BeneficiarioEmailObterTodos();
        BeneficiarioEmailViewModel BeneficiarioEmailAdicionar(BeneficiarioEmailViewModel beneficiarioEmailViewModel);
        BeneficiarioEmailViewModel BeneficiarioEmailAtualizar(BeneficiarioEmailViewModel beneficiarioEmailViewModel);
        //Telefone//     
        BeneficiarioTelefoneViewModel BeneficiarioTelefoneObterPorId(Guid id);
        IEnumerable<BeneficiarioTelefoneViewModel> BeneficiarioTelefoneObterTodos();
        BeneficiarioTelefoneViewModel BeneficiarioTelefoneAdicionar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel);
        BeneficiarioTelefoneViewModel BeneficiarioTelefoneAtualizar(BeneficiarioTelefoneViewModel beneficiarioTelefoneViewModel);
    }
}
