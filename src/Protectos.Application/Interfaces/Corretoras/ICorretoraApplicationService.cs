using Protectos.Application.ViewModels.Corretoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Corretoras
{
    public interface ICorretoraApplicationService
    {
        //Corretora//
        CorretoraViewModel CorretoraObterPorId(Guid id);
        CorretoraViewModel CorretoraObterPorCpf(string cnpj);
        IEnumerable<CorretoraViewModel> CorretoraObterTodos();
        IEnumerable<CorretoraViewModel> CorretoraObterAtivo();
        IEnumerable<CorretoraViewModel> CorretoraObterInativo();
        CorretoraViewModel CorretoraAdicionar(CorretoraViewModel corretoraViewModel);
        CorretoraViewModel CorretoraAtualizar(CorretoraViewModel corretoraViewModel);

        //Endereco//        
        IEnumerable<CorretoraEnderecoViewModel> CorretoraEnderecoObterTodos();
        CorretoraEnderecoViewModel CorretoraEnderecoAdicionar(CorretoraEnderecoViewModel corretoraEnderecoViewModel);
        CorretoraEnderecoViewModel CorretoraEnderecoAtualizar(CorretoraEnderecoViewModel corretoraEnderecoViewModel);

        //Email//      
        IEnumerable<CorretoraEmailViewModel> CorretoraEmailObterTodos();
        CorretoraEmailViewModel CorretoraEmailAdicionar(CorretoraEmailViewModel corretoraEmailViewModel);
        CorretoraEmailViewModel CorretoraEmailAtualizar(CorretoraEmailViewModel corretoraEmailViewModel);

        //Telefone//     
        IEnumerable<CorretoraTelefoneViewModel> CorretoraTelefoneObterTodos();
        CorretoraTelefoneViewModel CorretoraTelefoneAdicionar(CorretoraTelefoneViewModel corretoraTelefoneViewModel);
        CorretoraTelefoneViewModel CorretoraTelefoneAtualizar(CorretoraTelefoneViewModel corretoraTelefoneViewModel);
    }
}
