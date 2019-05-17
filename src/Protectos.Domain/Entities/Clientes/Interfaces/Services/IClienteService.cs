using System;
namespace Protectos.Domain.Entities.Clientes.Interfaces.Services
{
    public interface IClienteService
    {
        //Administradora
        Cliente ClienteAdicionar(Cliente cliente);
        Cliente ClienteAtualizar(Cliente cliente);
        void DeleteCliente(Guid id);

        //Email
        ClienteEmail ClienteEmailAdicionar(ClienteEmail clienteEmail);
        ClienteEmail ClienteEmailAtualizar(ClienteEmail clienteEmail);
        void DeleteClienteEmail(Guid id);

        //Telefone
        ClienteTelefone ClienteTelefoneAdicionar(ClienteTelefone clienteTelefone);
        ClienteTelefone ClienteTelefoneAtualizar(ClienteTelefone clienteTelefone);
        void DeleteClienteTelefone(Guid id);

        //Endereco
        ClienteEndereco ClienteEnderecoAdicionar(ClienteEndereco clienteEndereco);
        ClienteEndereco ClienteEnderecoAtualizar(ClienteEndereco clienteEndereco);
        void DeleteClienteEndereco(Guid id);
    }
}
