using Protectos.Application.ViewModels.Entidades;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Entidades
{
    public interface IEntidadeApplicationService
    {
        //Administrador//
        EntidadeViewModel EntidadeObterPorId(Guid id);
        EntidadeViewModel EntidadeObterPorCnpj(string cnpj);
        IEnumerable<EntidadeViewModel> EntidadeObterTodos();
        IEnumerable<EntidadeViewModel> EntidadeObterAtivo();
        IEnumerable<EntidadeViewModel> EntidadeObterInativo();
        EntidadeViewModel EntidadeAdicionar(EntidadeViewModel entidadeViewModel);
        EntidadeViewModel EntidadeAtualizar(EntidadeViewModel entidadeViewModel);
        void DeleteEntidade(Guid id);


        //Endereco//        
        IEnumerable<EntidadeEnderecoViewModel> EntidadeEnderecoObterTodos();
        EntidadeEnderecoViewModel EntidadeEnderecoAdicionar(EntidadeEnderecoViewModel entidadeEnderecoViewModel);
        EntidadeEnderecoViewModel EntidadeEnderecoAtualizar(EntidadeEnderecoViewModel entidadeEnderecoViewModel);
        void DeleteEntidadeEndereco(Guid id);

        //Email//      
        IEnumerable<EntidadeEmailViewModel> EntidadeEmailObterTodos();
        EntidadeEmailViewModel EntidadeEmailAdicionar(EntidadeEmailViewModel entidadeEmailViewModel);
        EntidadeEmailViewModel EntidadeEmailAtualizar(EntidadeEmailViewModel entidadeEmailViewModel);
        void DeleteEntidadeEmail(Guid id);

        //Telefone//     
        IEnumerable<EntidadeTelefoneViewModel> EntidadeTelefoneObterTodos();
        EntidadeTelefoneViewModel EntidadeTelefoneAdicionar(EntidadeTelefoneViewModel entidadeTelefoneViewModel);
        EntidadeTelefoneViewModel EntidadeTelefoneAtualizar(EntidadeTelefoneViewModel entidadeTelefoneViewModel);
        void DeleteEntidadeTelefone(Guid id);
    }
}
