using Protectos.Application.ViewModels.Operadoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Operadoras
{
    public interface IOperadoraApplicationService
    {
        //Operadora//
        OperadoraViewModel OperadoraObterPorId(Guid id);
        OperadoraViewModel OperadoraObterPorCpf(string cnpj);
        IEnumerable<OperadoraViewModel> OperadoraObterTodos();
        IEnumerable<OperadoraViewModel> OperadoraObterAtivo();
        IEnumerable<OperadoraViewModel> OperadoraObterInativo();
        OperadoraViewModel OperadoraAdicionar(OperadoraViewModel operadoraViewModel);
        OperadoraViewModel OperadoraAtualizar(OperadoraViewModel operadoraViewModel);

        //Endereco//        
        IEnumerable<OperadoraEnderecoViewModel> OperadoraEnderecoObterTodos();
        OperadoraEnderecoViewModel OperadoraEnderecoAdicionar(OperadoraEnderecoViewModel operadoraEnderecoViewModel);
        OperadoraEnderecoViewModel OperadoraEnderecoAtualizar(OperadoraEnderecoViewModel operadoraEnderecoViewModel);

        //Email//      
        IEnumerable<OperadoraEmailViewModel> OperadoraEmailObterTodos();
        OperadoraEmailViewModel OperadoraEmailAdicionar(OperadoraEmailViewModel operadoraEmailViewModel);
        OperadoraEmailViewModel OperadoraEmailAtualizar(OperadoraEmailViewModel operadoraEmailViewModel);

        //Telefone//     
        IEnumerable<OperadoraTelefoneViewModel> OperadoraTelefoneObterTodos();
        OperadoraTelefoneViewModel OperadoraTelefoneAdicionar(OperadoraTelefoneViewModel operadoraTelefoneViewModel);
        OperadoraTelefoneViewModel OperadoraTelefoneAtualizar(OperadoraTelefoneViewModel operadoraTelefoneViewModel);
    }
}
