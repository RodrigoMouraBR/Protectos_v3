using Protectos.Application.ViewModels.Clientes;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Clientes
{
    public interface IClienteApplicationService
    {      

        //Administrador//
        ClienteViewModel ClienteObterPorId(Guid id);
        ClienteViewModel ClienteObterPorCnpj(string cnpj);
        IEnumerable<ClienteViewModel> ClienteObterTodos();
        IEnumerable<ClienteViewModel> ClienteObterAtivo();
        IEnumerable<ClienteViewModel> ClienteObterInativo();
        //ClienteViewModel ClienteAdicionar(ClienteViewModel clienteViewModel);
        ClienteViewModel ClienteAtualizar(ClienteViewModel clienteViewModel);
        void DeleteCliente(Guid id);


        //Endereco//    
        ClienteEnderecoViewModel ClienteEnderecoObterPorId(Guid id);
        IEnumerable<ClienteEnderecoViewModel> ClienteEnderecoObterTodos();
        ClienteEnderecoViewModel ClienteEnderecoAdicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteEnderecoViewModel ClienteEnderecoAtualizar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        void DeleteClienteEndereco(Guid id);

        //Email//     
        ClienteEmailViewModel ClienteEmailObterPorId(Guid id);
        IEnumerable<ClienteEmailViewModel> ClienteEmailObterTodos();
        ClienteEmailViewModel ClienteEmailAdicionar(ClienteEmailViewModel clienteEmailViewModel);
        ClienteEmailViewModel ClienteEmailAtualizar(ClienteEmailViewModel clienteEmailViewModel);
        void DeleteClienteEmail(Guid id);

        //Telefone//    
        ClienteTelefoneViewModel ClienteTelefoneObterPorId(Guid id);
        IEnumerable<ClienteTelefoneViewModel> ClienteTelefoneObterTodos();
        ClienteTelefoneViewModel ClienteTelefoneAdicionar(ClienteTelefoneViewModel clienteTelefoneViewModel);
        ClienteTelefoneViewModel ClienteTelefoneAtualizar(ClienteTelefoneViewModel clienteTelefoneViewModel);
        void DeleteClienteTelefone(Guid id);
    }
}
