using Protectos.Application.ViewModels.Operadoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Operadoras
{
    public interface IOperadoraApplicationService : IDisposable
    {
        //Operadora//
        OperadoraViewModel OperadoraObterPorId(Guid id);
        OperadoraViewModel OperadoraObterPorCnpj(string cnpj);
        IEnumerable<OperadoraViewModel> OperadoraObterTodos();
        IEnumerable<OperadoraViewModel> OperadoraObterAtivo();
        IEnumerable<OperadoraViewModel> OperadoraObterInativo();
        OperadoraViewModel OperadoraAdicionar(OperadoraViewModel operadoraViewModel);
        OperadoraViewModel OperadoraAtualizar(OperadoraViewModel operadoraViewModel);
        void DeleteOperadora(Guid id);

        //Endereco//   
        OperadoraEnderecoViewModel EntidadeEnderecoObterPorId(Guid id);
        IEnumerable<OperadoraEnderecoViewModel> OperadoraEnderecoObterTodos();
        OperadoraEnderecoViewModel OperadoraEnderecoAdicionar(OperadoraEnderecoViewModel operadoraEnderecoViewModel);
        OperadoraEnderecoViewModel OperadoraEnderecoAtualizar(OperadoraEnderecoViewModel operadoraEnderecoViewModel);
        void DeleteOperadoraEndereco(Guid id);

        //Email//    
        OperadoraEmailViewModel EntidadeEmailObterPorId(Guid id);
        IEnumerable<OperadoraEmailViewModel> OperadoraEmailObterTodos();
        OperadoraEmailViewModel OperadoraEmailAdicionar(OperadoraEmailViewModel operadoraEmailViewModel);
        OperadoraEmailViewModel OperadoraEmailAtualizar(OperadoraEmailViewModel operadoraEmailViewModel);
        void DeleteOperadoraEmail(Guid id);

        //Telefone//     
        OperadoraTelefoneViewModel EntidadeTelefoneObterPorId(Guid id);
        IEnumerable<OperadoraTelefoneViewModel> OperadoraTelefoneObterTodos();
        OperadoraTelefoneViewModel OperadoraTelefoneAdicionar(OperadoraTelefoneViewModel operadoraTelefoneViewModel);
        OperadoraTelefoneViewModel OperadoraTelefoneAtualizar(OperadoraTelefoneViewModel operadoraTelefoneViewModel);
        void DeleteOperadoraTelefone(Guid id);
    }
}
