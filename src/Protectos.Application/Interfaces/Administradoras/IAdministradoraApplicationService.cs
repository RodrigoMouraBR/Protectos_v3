using Protectos.Application.ViewModels.Administradoras;
using System;
using System.Collections.Generic;
namespace Protectos.Application.Interfaces.Administradoras
{
    public interface IAdministradoraApplicationService
    {
        //BeneFiciario
        AdministradoraViewModel ObterPorId(Guid id);
        AdministradoraViewModel ObterBeneficiarioPorCpf(string cpf);
        IEnumerable<AdministradoraViewModel> ObterTodos();
        IEnumerable<AdministradoraViewModel> ObterBeneficiarioAtivo();
        IEnumerable<AdministradoraViewModel> ObterBeneficiarioInativo();
        AdministradoraViewModel Adicionar(AdministradoraViewModel beneficiarioViewModel);
        AdministradoraViewModel Atualizar(AdministradoraViewModel beneficiarioViewModel);
       
        //Endereco        
        IEnumerable<AdministradoraEnderecoViewModel> ObterBeneficiarioEnderecoTodos();
        AdministradoraEnderecoViewModel Adicionar(AdministradoraEnderecoViewModel beneficiarioEnderecoViewModel);
        AdministradoraEnderecoViewModel Atualizar(AdministradoraEnderecoViewModel beneficiarioEnderecoViewModel);
        
        //Email      
        IEnumerable<AdministradoraEmailViewModel> ObterAdministradoraEmailTodos();
        AdministradoraEmailViewModel Adicionar(AdministradoraEmailViewModel administradoraEmailViewModel);
        AdministradoraEmailViewModel Atualizar(AdministradoraEmailViewModel administradoraEmailViewModel);
       
        //Telefone     
        IEnumerable<AdministradoraTelefoneViewModel> BeneficiarioTelefoneObterTodos();
        AdministradoraTelefoneViewModel Adicionar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel);
        AdministradoraTelefoneViewModel Atualizar(AdministradoraTelefoneViewModel administradoraTelefoneViewModel);
        
    }
}
