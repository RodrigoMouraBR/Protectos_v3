using Protectos.Application.ViewModels.Operadoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Operadoras
{
    public interface IOperadoraApplicationService
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
        IEnumerable<OperadoraEnderecoViewModel> OperadoraEnderecoObterTodos();
        OperadoraEnderecoViewModel OperadoraEnderecoAdicionar(OperadoraEnderecoViewModel operadoraEnderecoViewModel);
        OperadoraEnderecoViewModel OperadoraEnderecoAtualizar(OperadoraEnderecoViewModel operadoraEnderecoViewModel);
        void DeleteOperadoraEndereco(Guid id);

        //Email//      
        IEnumerable<OperadoraEmailViewModel> OperadoraEmailObterTodos();
        OperadoraEmailViewModel OperadoraEmailAdicionar(OperadoraEmailViewModel operadoraEmailViewModel);
        OperadoraEmailViewModel OperadoraEmailAtualizar(OperadoraEmailViewModel operadoraEmailViewModel);
        void DeleteOperadoraEmail(Guid id);

        //Telefone//     
        IEnumerable<OperadoraTelefoneViewModel> OperadoraTelefoneObterTodos();
        OperadoraTelefoneViewModel OperadoraTelefoneAdicionar(OperadoraTelefoneViewModel operadoraTelefoneViewModel);
        OperadoraTelefoneViewModel OperadoraTelefoneAtualizar(OperadoraTelefoneViewModel operadoraTelefoneViewModel);
        void DeleteOperadoraTelefone(Guid id);
    }
}
