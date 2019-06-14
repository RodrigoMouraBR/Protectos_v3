using Protectos.Application.ViewModels.Filiais;
using System;
using System.Collections.Generic;

namespace Protectos.Application.Interfaces.Filiais
{
    public interface IFilialApplicationService : IDisposable
    {
        FilialCadastroViewModel FilialCadastroAdicionar(FilialCadastroViewModel filialCadastroViewModel);

        //Administrador//
        FilialViewModel FilialObterPorId(Guid id);
        FilialViewModel FilialObterPorCnpj(string cnpj);
        IEnumerable<FilialViewModel> FilialObterTodos();
        IEnumerable<FilialViewModel> FilialObterAtivo();
        IEnumerable<FilialViewModel> FilialObterInativo();
        //FilialViewModel FilialAdicionar(FilialViewModel filialViewModel);
        FilialViewModel FilialAtualizar(FilialViewModel filialViewModel);
        void DeleteFilial(Guid id);


        //Endereco//    
        FilialEnderecoViewModel FilialEnderecoObterPorId(Guid id);
        IEnumerable<FilialEnderecoViewModel> FilialEnderecoObterTodos();
        FilialEnderecoViewModel FilialEnderecoAdicionar(FilialEnderecoViewModel filialEnderecoViewModel);
        FilialEnderecoViewModel FilialEnderecoAtualizar(FilialEnderecoViewModel filialEnderecoViewModel);
        void DeleteFilialEndereco(Guid id);

        //Email//     
        FilialEmailViewModel FilialEmailObterPorId(Guid id);
        IEnumerable<FilialEmailViewModel> FilialEmailObterTodos();
        FilialEmailViewModel FilialEmailAdicionar(FilialEmailViewModel filialEmailViewModel);
        FilialEmailViewModel FilialEmailAtualizar(FilialEmailViewModel filialEmailViewModel);
        void DeleteFilialEmail(Guid id);

        //Telefone//    
        FilialTelefoneViewModel FilialTelefoneObterPorId(Guid id);
        IEnumerable<FilialTelefoneViewModel> FilialTelefoneObterTodos();
        FilialTelefoneViewModel FilialTelefoneAdicionar(FilialTelefoneViewModel filialTelefoneViewModel);
        FilialTelefoneViewModel FilialTelefoneAtualizar(FilialTelefoneViewModel filialTelefoneViewModel);
        void DeleteFilialTelefone(Guid id);
    }
}
