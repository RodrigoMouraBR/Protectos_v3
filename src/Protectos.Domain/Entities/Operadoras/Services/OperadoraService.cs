using Protectos.Domain.Entities.Operadoras.Interfaces;
using Protectos.Domain.Entities.Operadoras.Interfaces.Services;
using System;
namespace Protectos.Domain.Entities.Operadoras.Services
{
    public class OperadoraService : IOperadoraService
    {
        private readonly IOperadoraRepository _operadoraRepository;
        private readonly IOperadoraEmailRepository _operadoraEmailRepository;
        private readonly IOperadoraTelefoneRepository _operadoraTelefoneRepository;
        private readonly IOperadoraEnderecoRepository _operadoraEnderecoRepository;
        public OperadoraService(IOperadoraRepository operadoraRepository,
                                     IOperadoraEmailRepository operadoraEmailRepository,
                                     IOperadoraTelefoneRepository operadoraTelefoneRepository,
                                     IOperadoraEnderecoRepository operadoraEnderecoRepository)
        {
            _operadoraRepository = operadoraRepository;
            _operadoraEmailRepository = operadoraEmailRepository;
            _operadoraTelefoneRepository = operadoraTelefoneRepository;
            _operadoraEnderecoRepository = operadoraEnderecoRepository;
        }

        

        //Operadora
        public Operadora OperadoraAdicionar(Operadora operadora)
        {
            //if (!operadora.IsValid())
            //    return operadora;
            _operadoraRepository.Add(operadora);
            return operadora;
        }
        public Operadora OperadoraAtualizar(Operadora operadora)
        {
            return _operadoraRepository.Update(operadora);
        }
        public void DeleteOperadora(Guid id)
        {
            throw new NotImplementedException();
        }
        //Endereco
        public OperadoraEndereco OperadoraEnderecoAdicionar(OperadoraEndereco operadoraEndereco)
        {
            //if (!operadoraEndereco.IsValid())
            //    return operadoraEndereco;
            _operadoraEnderecoRepository.Add(operadoraEndereco);
            return operadoraEndereco;
        }
        public OperadoraEndereco OperadoraEnderecoAtualizar(OperadoraEndereco operadoraEndereco)
        {
            return _operadoraEnderecoRepository.Update(operadoraEndereco);
        }
        public void DeleteOperadoraEndereco(Guid id)
        {
            throw new NotImplementedException();
        }
        //Email
        public OperadoraEmail OperadoraEmailAdicionar(OperadoraEmail operadoraEmail)
        {
            //if (!operadoraEmail.IsValid())
            //    return operadoraEmail;
            _operadoraEmailRepository.Add(operadoraEmail);
            return operadoraEmail;
        }
        public OperadoraEmail OperadoraEmailAtualizar(OperadoraEmail operadoraEmail)
        {
            return _operadoraEmailRepository.Update(operadoraEmail);
        }
        public void DeleteOperadoraEmail(Guid id)
        {
            throw new NotImplementedException();
        }
        //Telefone
        public OperadoraTelefone OperadoraTelefoneAdicionar(OperadoraTelefone operadoraTelefone)
        {
            //if (!operadoraTelefone.IsValid())
            //    return operadoraTelefone;
            _operadoraTelefoneRepository.Add(operadoraTelefone);
            return operadoraTelefone;
        }
        public OperadoraTelefone OperadoraTelefoneAtualizar(OperadoraTelefone operadoraTelefone)
        {
            return _operadoraTelefoneRepository.Update(operadoraTelefone);
        }
        public void DeleteOperadoraTelefone(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _operadoraRepository.Dispose();
            _operadoraEmailRepository.Dispose();
            _operadoraTelefoneRepository.Dispose();
            _operadoraEnderecoRepository.Dispose();
        }

    }
}
