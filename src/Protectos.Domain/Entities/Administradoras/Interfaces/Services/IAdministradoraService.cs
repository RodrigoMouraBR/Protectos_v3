using Protectos.Domain.DTO;
using Protectos.Domain.Generics.Interfaces.Services;
using System;

namespace Protectos.Domain.Entities.Administradoras.Interfaces.Services
{
    public interface IAdministradoraService : IDisposable
    {
        //Administradora
        Administradora AdministradoraAdicionar(Administradora administradora);
        Administradora AdministradoraAtualizar(Administradora administradora);
        void DeleteAdministradora(Guid id);

        ViaCep ConsultaraServicoViaCEP(string cep);

        //Email
        AdministradoraEmail AdministradoraEmailAdicionar(AdministradoraEmail administradoraEmail);
        AdministradoraEmail AdministradoraEmailAtualizar(AdministradoraEmail administradoraEmail);
        void DeleteAdministradoraEmail(Guid id);

        //Telefone
        AdministradoraTelefone AdministradoraTelefoneAdicionar(AdministradoraTelefone administradoraTelefone);
        AdministradoraTelefone AdministradoraTelefoneAtualizar(AdministradoraTelefone administradoraTelefone);
        void DeleteAdministradoraTelefone(Guid id);

        //Endereco
        AdministradoraEndereco AdministradoraEnderecoAdicionar(AdministradoraEndereco administradoraEndereco);
        AdministradoraEndereco AdministradoraEnderecoAtualizar(AdministradoraEndereco administradoraEndereco);
        void DeleteAdministradoraEndereco(Guid id);
    }
}