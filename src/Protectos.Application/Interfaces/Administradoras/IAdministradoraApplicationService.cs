using Protectos.Application.ViewModels.Administradoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Administradoras
{
    public interface IAdministradoraApplicationService
    {
        //Administrador//
        AdministradoraViewModel AdministradoraObterPorId(Guid id);
        AdministradoraViewModel AdministradoraObterPorCpf(string cnpj);
        IEnumerable<AdministradoraViewModel> AdministradoraObterTodos();
        IEnumerable<AdministradoraViewModel> AdministradoraObterAtivo();
        IEnumerable<AdministradoraViewModel> AdministradoraObterInativo();
        AdministradoraViewModel AdministradoraAdicionar(AdministradoraViewModel administradoraViewModel);
        AdministradoraViewModel AdministradoraAtualizar(AdministradoraViewModel administradoraViewModel);
        
        //Endereco//        
        IEnumerable<AdministradoraEnderecoViewModel> AdministradoraEnderecoObterTodos();
        AdministradoraEnderecoViewModel AdministradoraEnderecoAdicionar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel);
        AdministradoraEnderecoViewModel AdministradoraEnderecoAtualizar(AdministradoraEnderecoViewModel administradoraEnderecoViewModel);
        
        //Email//      
        IEnumerable<AdministradoraEmailViewModel> AdministradoraEmailObterTodos();
        AdministradoraEmailViewModel AdministradoraEmailAdicionar(AdministradoraEmailViewModel administradoraEmailViewModel);
        AdministradoraEmailViewModel AdministradoraEmailAtualizar(AdministradoraEmailViewModel administradoraEmailViewModel);
        
        //Telefone//     
        IEnumerable<AdministradoraTelefoneViewModel> AdministradoraTelefoneObterTodos();
        AdministradoraTelefoneViewModel AdministradoraTelefoneAdicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel);
        AdministradoraTelefoneViewModel AdministradoraTelefoneAtualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel);
    }
}
