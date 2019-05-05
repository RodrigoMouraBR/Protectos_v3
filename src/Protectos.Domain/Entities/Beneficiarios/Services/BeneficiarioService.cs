using System;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Services;
namespace Protectos.Domain.Entities.Beneficiarios.Services
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IBeneficiarioRepository _beneficiarioRepository;
        private readonly IBeneficiarioEmailRepository _beneficiarioEmailRepository;
        private readonly IBeneficiarioTelefoneRepository _beneficiarioTelefoneRepository;
        private readonly IBeneficiarioEnderecoRepository _beneficiarioEnderecoRepository;
        private readonly IBeneficiarioDependenteRepository _beneficiarioDependenteRepository;

        public BeneficiarioService(IBeneficiarioRepository beneficiarioRepository, 
            IBeneficiarioEmailRepository beneficiarioEmailRepository, 
            IBeneficiarioTelefoneRepository beneficiarioTelefoneRepository, 
            IBeneficiarioEnderecoRepository beneficiarioEnderecoRepository, 
            IBeneficiarioDependenteRepository beneficiarioDependenteRepository)
        {
            _beneficiarioRepository = beneficiarioRepository;
            _beneficiarioEmailRepository = beneficiarioEmailRepository;
            _beneficiarioTelefoneRepository = beneficiarioTelefoneRepository;
            _beneficiarioEnderecoRepository = beneficiarioEnderecoRepository;
            _beneficiarioDependenteRepository = beneficiarioDependenteRepository;
        }
        //Beneficiario
        public Beneficiario BeneficiarioAdicionar(Beneficiario beneficiario)
        {
            if (!beneficiario.IsValid())
                return beneficiario;
            _beneficiarioRepository.Add(beneficiario);
            return beneficiario;
        }
        public Beneficiario BeneficiarioAtualizar(Beneficiario beneficiario)
        {
            if (!beneficiario.IsValid())
                return beneficiario;
            _beneficiarioRepository.Update(beneficiario);
            return beneficiario;
        }
        public void BeneficiarioDelete(Guid id)
        {
            _beneficiarioRepository.Delete(id);
        }
        //Dependente
        public BeneficiarioDependente BeneficiarioDependenteAdicionar(BeneficiarioDependente beneficiarioDependente)
        {
            if (!beneficiarioDependente.IsValid())
                return beneficiarioDependente;
            _beneficiarioDependenteRepository.Add(beneficiarioDependente);
            return beneficiarioDependente;
        }
        public BeneficiarioDependente BeneficiarioDependenteAtualizar(BeneficiarioDependente beneficiarioDependente)
        {
            if (!beneficiarioDependente.IsValid())
                return beneficiarioDependente;
            _beneficiarioDependenteRepository.Update(beneficiarioDependente);
            return beneficiarioDependente;
        }
        public void BeneficiarioDependenteDelete(Guid id)
        {
            _beneficiarioDependenteRepository.Delete(id);
        }
        //Endereco
        public BeneficiarioEndereco BeneficiarioEnderecoAdicionar(BeneficiarioEndereco beneficiarioEndereco)
        {
            if (!beneficiarioEndereco.IsValid())
                return beneficiarioEndereco;
            _beneficiarioEnderecoRepository.Add(beneficiarioEndereco);
            return beneficiarioEndereco;
        }
        public BeneficiarioEndereco BeneficiarioEnderecoAtualizar(BeneficiarioEndereco beneficiarioEndereco)
        {
            if (!beneficiarioEndereco.IsValid())
                return beneficiarioEndereco;
            _beneficiarioEnderecoRepository.Update(beneficiarioEndereco);
            return beneficiarioEndereco;
        }
        public void BeneficiarioEnderecoDelete(Guid id)
        {
            _beneficiarioEnderecoRepository.Delete(id);
        }
        //Email
        public BeneficiarioEmail BeneficiarioEmailAdicionar(BeneficiarioEmail beneficiarioEmail)
        {
            if (!beneficiarioEmail.IsValid())
                return beneficiarioEmail;
            _beneficiarioEmailRepository.Add(beneficiarioEmail);
            return beneficiarioEmail;
        }
        public BeneficiarioEmail BeneficiarioEmailAtualizar(BeneficiarioEmail beneficiarioEmail)
        {
            if (!beneficiarioEmail.IsValid())
                return beneficiarioEmail;
            _beneficiarioEmailRepository.Update(beneficiarioEmail);
            return beneficiarioEmail;
        }
        public void BeneficiarioEmailDelete(Guid id)
        {
            _beneficiarioEmailRepository.Delete(id);
        }
        //Telefone
        public BeneficiarioTelefone BeneficiarioTelefoneAdicionar(BeneficiarioTelefone beneficiarioTelefone)
        {
            if (!beneficiarioTelefone.IsValid())
                return beneficiarioTelefone;
            _beneficiarioTelefoneRepository.Add(beneficiarioTelefone);
            return beneficiarioTelefone;
        }
        public BeneficiarioTelefone BeneficiarioTelefoneAtualizar(BeneficiarioTelefone beneficiarioTelefone)
        {
            if (!beneficiarioTelefone.IsValid())
                return beneficiarioTelefone;
            _beneficiarioTelefoneRepository.Update(beneficiarioTelefone);
            return beneficiarioTelefone;
        }
        public void BeneficiariTelefoneDelete(Guid id)
        {
            _beneficiarioTelefoneRepository.Delete(id);
        }
    }
}
