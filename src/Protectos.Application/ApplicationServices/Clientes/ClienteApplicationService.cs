using Protectos.Application.Interfaces.Clientes;
using Protectos.Application.ViewModels.Clientes;
using Protectos.Domain.Entities.Clientes.Interfaces.Repositories;
using Protectos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ApplicationServices.Clientes
{
    public class ClienteApplicationService : ApplicationService, IClienteApplicationService
    {

        //private readonly IClienteRepository _clienteRepository;
        //private readonly IClienteEmailRepository _clienteEmailRepository;
        //private readonly IClienteTelefoneRepository _clienteTelefoneRepository;
        //private readonly IClienteEnderecoRepository _clienteEndrecoRepository;

        public ClienteApplicationService(IUnitOfWork uow) : base(uow)
        {
        }

        // private readonly IClienteService _clienteService;

        public ClienteViewModel ClienteAtualizar(ClienteViewModel clienteViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEmailViewModel ClienteEmailAdicionar(ClienteEmailViewModel clienteEmailViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEmailViewModel ClienteEmailAtualizar(ClienteEmailViewModel clienteEmailViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEmailViewModel ClienteEmailObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteEmailViewModel> ClienteEmailObterTodos()
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoViewModel ClienteEnderecoAdicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoViewModel ClienteEnderecoAtualizar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoViewModel ClienteEnderecoObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteEnderecoViewModel> ClienteEnderecoObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ClienteObterAtivo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ClienteObterInativo()
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ClienteObterPorCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ClienteObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ClienteObterTodos()
        {
            throw new NotImplementedException();
        }

        public ClienteTelefoneViewModel ClienteTelefoneAdicionar(ClienteTelefoneViewModel clienteTelefoneViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteTelefoneViewModel ClienteTelefoneAtualizar(ClienteTelefoneViewModel clienteTelefoneViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteTelefoneViewModel ClienteTelefoneObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteTelefoneViewModel> ClienteTelefoneObterTodos()
        {
            throw new NotImplementedException();
        }

        public void DeleteCliente(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteClienteEmail(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteClienteEndereco(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteClienteTelefone(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
