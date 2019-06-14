using Protectos.Application.ViewModels.Fornecedores;
using System;
using System.Collections.Generic;

namespace Protectos.Application.Interfaces.Fornecedores
{
    public interface IFornecedorApplicationService : IDisposable
    {
        FornecedorCadastroViewModel FornecedorCadastroAdicionar(FornecedorCadastroViewModel fornecedorCadastroViewModel);

        //Administrador//
        FornecedorViewModel FornecedorObterPorId(Guid id);
        FornecedorViewModel FornecedorObterPorCnpj(string cnpj);
        IEnumerable<FornecedorViewModel> FornecedorObterTodos();
        IEnumerable<FornecedorViewModel> FornecedorObterAtivo();
        IEnumerable<FornecedorViewModel> FornecedorObterInativo();
        //FornecedorViewModel FornecedorAdicionar(FornecedorViewModel fornecedorViewModel);
        FornecedorViewModel FornecedorAtualizar(FornecedorViewModel fornecedorViewModel);
        void DeleteFornecedor(Guid id);


        //Endereco//    
        FornecedorEnderecoViewModel FornecedorEnderecoObterPorId(Guid id);
        IEnumerable<FornecedorEnderecoViewModel> FornecedorEnderecoObterTodos();
        FornecedorEnderecoViewModel FornecedorEnderecoAdicionar(FornecedorEnderecoViewModel fornecedorEnderecoViewModel);
        FornecedorEnderecoViewModel FornecedorEnderecoAtualizar(FornecedorEnderecoViewModel fornecedorEnderecoViewModel);
        void DeleteFornecedorEndereco(Guid id);

        //Email//     
        FornecedorEmailViewModel FornecedorEmailObterPorId(Guid id);
        IEnumerable<FornecedorEmailViewModel> FornecedorEmailObterTodos();
        FornecedorEmailViewModel FornecedorEmailAdicionar(FornecedorEmailViewModel fornecedorEmailViewModel);
        FornecedorEmailViewModel FornecedorEmailAtualizar(FornecedorEmailViewModel fornecedorEmailViewModel);
        void DeleteFornecedorEmail(Guid id);

        //Telefone//    
        FornecedorTelefoneViewModel FornecedorTelefoneObterPorId(Guid id);
        IEnumerable<FornecedorTelefoneViewModel> FornecedorTelefoneObterTodos();
        FornecedorTelefoneViewModel FornecedorTelefoneAdicionar(FornecedorTelefoneViewModel fornecedorTelefoneViewModel);
        FornecedorTelefoneViewModel FornecedorTelefoneAtualizar(FornecedorTelefoneViewModel fornecedorTelefoneViewModel);
        void DeleteFornecedorTelefone(Guid id);
    }
}
