using Protectos.Application.ViewModels.Administradoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Administradoras
{
    public interface IAdministradoraApplicationService : IDisposable
    {

        AdministradoraCadastroViewModel AdministradoraCadastroAdicionar(AdministradoraCadastroViewModel administradoraCadastroViewModel);

        //Administrador//
        AdministradoraViewModel AdministradoraObterPorId(Guid id);
        AdministradoraViewModel AdministradoraObterPorCnpj(string cnpj);
        IEnumerable<AdministradoraViewModel> AdministradoraObterTodos();
        IEnumerable<AdministradoraViewModel> AdministradoraObterAtivo();
        IEnumerable<AdministradoraViewModel> AdministradoraObterInativo();
        //AdministradoraViewModel AdministradoraAdicionar(AdministradoraViewModel administradoraViewModel);
        AdministradoraViewModel AdministradoraAtualizar(AdministradoraViewModel administradoraViewModel);
        void DeleteAdministradora(Guid id);


        //Endereco//    
        AdministradoraEnderecoViewModel AdministradoraEnderecoObterPorId(Guid id);
        IEnumerable<AdministradoraEnderecoViewModel> AdministradoraEnderecoObterTodos();
        AdministradoraEnderecoViewModel AdministradoraEnderecoAdicionar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel);
        AdministradoraEnderecoViewModel AdministradoraEnderecoAtualizar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel);
        void DeleteAdministradoraEndereco(Guid id);

        //Email//     
        AdministradoraEmailViewModel AdministradoraEmailObterPorId(Guid id);
        IEnumerable<AdministradoraEmailViewModel> AdministradoraEmailObterTodos();
        AdministradoraEmailViewModel AdministradoraEmailAdicionar(AdministradoraEmailViewModel administradoraEmailViewModel);
        AdministradoraEmailViewModel AdministradoraEmailAtualizar(AdministradoraEmailViewModel administradoraEmailViewModel);
        void DeleteAdministradoraEmail(Guid id);

        //Telefone//    
        AdministradoraTelefoneViewModel AdministradoraTelefoneObterPorId(Guid id);
        IEnumerable<AdministradoraTelefoneViewModel> AdministradoraTelefoneObterTodos();
        AdministradoraTelefoneViewModel AdministradoraTelefoneAdicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel);
        AdministradoraTelefoneViewModel AdministradoraTelefoneAtualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel);
        void DeleteAdministradoraTelefone(Guid id);
    }
}
