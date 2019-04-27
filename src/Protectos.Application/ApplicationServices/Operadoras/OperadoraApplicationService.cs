using Protectos.Application.Interfaces.Operadoras;
using Protectos.Application.ViewModels.Operadoras;
using System;
using System.Collections.Generic;

namespace Protectos.Application.ApplicationServices.Operadoras
{
    public class OperadoraApplicationService : IOperadoraApplicationService
    {
        public OperadoraViewModel OperadoraAdicionar(OperadoraViewModel operadoraViewModel)
        {
            //IMPLEMENTANDO SERVIÇO APPLICATIONS
            throw new NotImplementedException();
        }
        public OperadoraViewModel OperadoraAtualizar(OperadoraViewModel operadoraViewModel)
        {
            throw new NotImplementedException();
        }
        public OperadoraEmailViewModel OperadoraEmailAdicionar(OperadoraEmailViewModel operadoraEmailViewModel)
        {
            throw new NotImplementedException();
        }
        public OperadoraEmailViewModel OperadoraEmailAtualizar(OperadoraEmailViewModel operadoraEmailViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadoraEmailViewModel> OperadoraEmailObterTodos()
        {
            throw new NotImplementedException();
        }
        public OperadoraEnderecoViewModel OperadoraEnderecoAdicionar(OperadoraEnderecoViewModel operadoraEnderecoViewModel)
        {
            throw new NotImplementedException();
        }
        public OperadoraEnderecoViewModel OperadoraEnderecoAtualizar(OperadoraEnderecoViewModel operadoraEnderecoViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadoraEnderecoViewModel> OperadoraEnderecoObterTodos()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadoraViewModel> OperadoraObterAtivo()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadoraViewModel> OperadoraObterInativo()
        {
            throw new NotImplementedException();
        }
        public OperadoraViewModel OperadoraObterPorCpf(string cnpj)
        {
            throw new NotImplementedException();
        }
        public OperadoraViewModel OperadoraObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadoraViewModel> OperadoraObterTodos()
        {
            throw new NotImplementedException();
        }
        public OperadoraTelefoneViewModel OperadoraTelefoneAdicionar(OperadoraTelefoneViewModel operadoraTelefoneViewModel)
        {
            throw new NotImplementedException();
        }
        public OperadoraTelefoneViewModel OperadoraTelefoneAtualizar(OperadoraTelefoneViewModel operadoraTelefoneViewModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadoraTelefoneViewModel> OperadoraTelefoneObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
