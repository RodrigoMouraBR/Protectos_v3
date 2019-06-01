using System;
using Protectos.Domain.DTO;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using Protectos.Domain.Generics.Interfaces.Services;

namespace Protectos.Domain.Entities.Administradoras.Services
{
    public class AdministradoraService : IAdministradoraService
    {
        private readonly IAdministradoraRepository _administradoraRepository;
        private readonly IAdministradoraEmailRepository _administradoraEmailRepository;
        private readonly IAdministradoraTelefoneRepository _administradoraTelefoneRepository;
        private readonly IAdministradoraEnderecoRepository _administradoraEnderecoRepository;
        private readonly IViaCepExternalService _viaCepExternalService;

        public AdministradoraService(IAdministradoraRepository administradoraRepository,
                                     IAdministradoraEmailRepository administradoraEmailRepository,
                                     IAdministradoraTelefoneRepository administradoraTelefoneRepository,
                                     IAdministradoraEnderecoRepository administradoraEnderecoRepository,
                                     IViaCepExternalService viaCepExternalService
                                    )
        {
            _administradoraRepository = administradoraRepository;
            _administradoraEmailRepository = administradoraEmailRepository;
            _administradoraTelefoneRepository = administradoraTelefoneRepository;
            _administradoraEnderecoRepository = administradoraEnderecoRepository;
            _viaCepExternalService = viaCepExternalService;
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
            _administradoraRepository.Delete(id);
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
            _administradoraEnderecoRepository.Delete(id);
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
            _administradoraEmailRepository.Delete(id);
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
            _administradoraTelefoneRepository.Delete(id);
        }

        public void Dispose()
        {
            _administradoraRepository.Dispose();
            _administradoraEmailRepository.Dispose();
            _administradoraTelefoneRepository.Dispose();
            _administradoraEnderecoRepository.Dispose();
        }

        public ViaCep ConsultaraServicoViaCEP(string cep)
        {
            var retorno = _viaCepExternalService.ConsultarCEP(cep);
            return retorno;
        }
    }    
}