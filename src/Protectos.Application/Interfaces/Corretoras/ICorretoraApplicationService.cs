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
        CorretoraCadastroViewModel CorretoraCadastroAdicionar(CorretoraCadastroViewModel corretoraCadastroViewModel);
        CorretoraViewModel CorretoraAtualizar(CorretoraViewModel corretoraViewModel);
        void DeleteCorretora(Guid id);

        //Endereco//     
        CorretoraEnderecoViewModel CorretoraEnderecoObterPorId(Guid id);
        IEnumerable<CorretoraEnderecoViewModel> CorretoraEnderecoObterTodos();
        CorretoraEnderecoViewModel CorretoraEnderecoAdicionar(CorretoraEnderecoViewModel corretoraEnderecoViewModel);
        CorretoraEnderecoViewModel CorretoraEnderecoAtualizar(CorretoraEnderecoViewModel corretoraEnderecoViewModel);
        void DeleteCorretoraEndereco(Guid id);
        //Email//    
        CorretoraEmailViewModel CorretoraEmailObterPorId(Guid id);
        IEnumerable<CorretoraEmailViewModel> CorretoraEmailObterTodos();
        CorretoraEmailViewModel CorretoraEmailAdicionar(CorretoraEmailViewModel corretoraEmailViewModel);
        CorretoraEmailViewModel CorretoraEmailAtualizar(CorretoraEmailViewModel corretoraEmailViewModel);
        void DeleteCorretoraEmail(Guid id);

        //Telefone//    
        CorretoraTelefoneViewModel CorretoraTelefoneObterPorId(Guid id);
        IEnumerable<CorretoraTelefoneViewModel> CorretoraTelefoneObterTodos();
        CorretoraTelefoneViewModel CorretoraTelefoneAdicionar(CorretoraTelefoneViewModel corretoraTelefoneViewModel);
        CorretoraTelefoneViewModel CorretoraTelefoneAtualizar(CorretoraTelefoneViewModel corretoraTelefoneViewModel);
        void DeleteCorretoraTelefone(Guid id);
    }
}
