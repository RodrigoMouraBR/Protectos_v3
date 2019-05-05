using System;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
namespace Protectos.Domain.Entities.Administradoras.Services
{
    public class AdministradoraService : IAdministradoraService
    {       
        private readonly IAdministradoraRepository _administradoraRepository;
        private readonly IAdministradoraEmailRepository _administradoraEmailRepository;
        private readonly IAdministradoraTelefoneRepository _administradoraTelefoneRepository;
        private readonly IAdministradoraEnderecoRepository _administradoraEnderecoRepository;
        public AdministradoraService(IAdministradoraRepository administradoraRepository, 
                                     IAdministradoraEmailRepository administradoraEmailRepository, 
                                     IAdministradoraTelefoneRepository administradoraTelefoneRepository, 
                                     IAdministradoraEnderecoRepository administradoraEnderecoRepository)
        {
            _administradoraRepository = administradoraRepository;
            _administradoraEmailRepository = administradoraEmailRepository;
            _administradoraTelefoneRepository = administradoraTelefoneRepository;
            _administradoraEnderecoRepository = administradoraEnderecoRepository;
        }
        //Administradora
        public Administradora AdministradoraAdicionar(Administradora administradora)
        {
            if (!administradora.IsValid())
                return administradora;
            _administradoraRepository.Add(administradora);
            return administradora;
        }
        public Administradora AdministradoraAtualizar(Administradora administradora)
        {
            return _administradoraRepository.Update(administradora);
        }  
        public void DeleteAdministradora(Guid id)
        {
            throw new NotImplementedException();
        }
        //Endereco
        public AdministradoraEndereco AdministradoraEnderecoAdicionar(AdministradoraEndereco administradoraEndereco)
        {
            if (!administradoraEndereco.IsValid())
                return administradoraEndereco;
            _administradoraEnderecoRepository.Add(administradoraEndereco);
            return administradoraEndereco;
        }
        public AdministradoraEndereco AdministradoraEnderecoAtualizar(AdministradoraEndereco administradoraEndereco)
        {
            return _administradoraEnderecoRepository.Update(administradoraEndereco);
        }
        public void DeleteAdministradoraEndereco(Guid id)
        {
            throw new NotImplementedException();
        }
        //Email
        public AdministradoraEmail AdministradoraEmailAdicionar(AdministradoraEmail administradoraEmail)
        {
            if (!administradoraEmail.IsValid())
                return administradoraEmail;
            _administradoraEmailRepository.Add(administradoraEmail);
            return administradoraEmail;
        }
        public AdministradoraEmail AdministradoraEmailAtualizar(AdministradoraEmail administradoraEmail)
        {
            return _administradoraEmailRepository.Update(administradoraEmail);
        }
        public void DeleteAdministradoraEmail(Guid id)
        {
            throw new NotImplementedException();
        }
        //Telefone
        public AdministradoraTelefone AdministradoraTelefoneAdicionar(AdministradoraTelefone administradoraTelefone)
        {
            if (!administradoraTelefone.IsValid())
                return administradoraTelefone;
            _administradoraTelefoneRepository.Add(administradoraTelefone);
            return administradoraTelefone;
        }
        public AdministradoraTelefone AdministradoraTelefoneAtualizar(AdministradoraTelefone administradoraTelefone)
        {
            return _administradoraTelefoneRepository.Update(administradoraTelefone);
        }
        public void DeleteAdministradoraTelefone(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}