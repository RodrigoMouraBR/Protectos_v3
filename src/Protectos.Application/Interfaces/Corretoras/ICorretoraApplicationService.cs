using Protectos.Application.ViewModels.Corretoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Corretoras
{
    public interface ICorretoraApplicationService : IDisposable
    {
        //Corretora//
        CorretoraViewModel CorretoraObterPorId(Guid id);
        CorretoraViewModel CorretoraObterPorCnpj(string cnpj);
        IEnumerable<CorretoraViewModel> CorretoraObterTodos();
        IEnumerable<CorretoraViewModel> CorretoraObterAtivo();
        IEnumerable<CorretoraViewModel> CorretoraObterInativo();
        CorretoraViewModel CorretoraAdicionar(CorretoraViewModel corretoraViewModel);
        CorretoraViewModel CorretoraAtualizar(CorretoraViewModel corretoraViewModel);
        void DeleteCorretora(Guid id);

        //Endereco//        
        IEnumerable<CorretoraEnderecoViewModel> CorretoraEnderecoObterTodos();
        CorretoraEnderecoViewModel CorretoraEnderecoAdicionar(CorretoraEnderecoViewModel corretoraEnderecoViewModel);
        CorretoraEnderecoViewModel CorretoraEnderecoAtualizar(CorretoraEnderecoViewModel corretoraEnderecoViewModel);
        void DeleteCorretoraEndereco(Guid id);
        //Email//      
        IEnumerable<CorretoraEmailViewModel> CorretoraEmailObterTodos();
        CorretoraEmailViewModel CorretoraEmailAdicionar(CorretoraEmailViewModel corretoraEmailViewModel);
        CorretoraEmailViewModel CorretoraEmailAtualizar(CorretoraEmailViewModel corretoraEmailViewModel);
        void DeleteCorretoraEmail(Guid id);

        //Telefone//     
        IEnumerable<CorretoraTelefoneViewModel> CorretoraTelefoneObterTodos();
        CorretoraTelefoneViewModel CorretoraTelefoneAdicionar(CorretoraTelefoneViewModel corretoraTelefoneViewModel);
        CorretoraTelefoneViewModel CorretoraTelefoneAtualizar(CorretoraTelefoneViewModel corretoraTelefoneViewModel);
        void DeleteCorretoraTelefone(Guid id);
    }
}
