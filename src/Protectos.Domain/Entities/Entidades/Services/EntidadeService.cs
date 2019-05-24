using Protectos.Domain.Entities.Entidades.Interfaces.Repositories;
using Protectos.Domain.Entities.Entidades.Interfaces.Services;
using System;
namespace Protectos.Domain.Entities.Entidades.Services
{
    public class EntidadeService : IEntidadeService
    {
        private readonly IEntidadeRepository _entidadeRepository;
        private readonly IEntidadeEmailRepository _entidadeEmailRepository;
        private readonly IEntidadeTelefoneRepository _entidadeTelefoneRepository;
        private readonly IEntidadeEnderecoRepository _entidadeEnderecoRepository;
        public EntidadeService(IEntidadeRepository entidadeRepository,
                                     IEntidadeEmailRepository entidadeEmailRepository,
                                     IEntidadeTelefoneRepository entidadeTelefoneRepository,
                                     IEntidadeEnderecoRepository entidadeEnderecoRepository)
        {
            _entidadeRepository = entidadeRepository;
            _entidadeEmailRepository = entidadeEmailRepository;
            _entidadeTelefoneRepository = entidadeTelefoneRepository;
            _entidadeEnderecoRepository = entidadeEnderecoRepository;
        }
        //Entidade
        public Entidade EntidadeAdicionar(Entidade Entidade)
        {
            //if (!Entidade.IsValid())
            //    return Entidade;
            _entidadeRepository.Add(Entidade);
            return Entidade;
        }
        public Entidade EntidadeAtualizar(Entidade Entidade)
        {
            return _entidadeRepository.Update(Entidade);
        }
        public void DeleteEntidade(Guid id)
        {
            _entidadeRepository.Delete(id);
        }
        //Endereco
        public EntidadeEndereco EntidadeEnderecoAdicionar(EntidadeEndereco entidadeEndereco)
        {
            //if (!entidadeEndereco.IsValid())
            //    return entidadeEndereco;
            _entidadeEnderecoRepository.Add(entidadeEndereco);
            return entidadeEndereco;
        }
        public EntidadeEndereco EntidadeEnderecoAtualizar(EntidadeEndereco entidadeEndereco)
        {
            return _entidadeEnderecoRepository.Update(entidadeEndereco);
        }
        public void DeleteEntidadeEndereco(Guid id)
        {
            _entidadeEnderecoRepository.Delete(id);
        }
        //Email
        public EntidadeEmail EntidadeEmailAdicionar(EntidadeEmail entidadeEmail)
        {
            //if (!entidadeEmail.IsValid())
            //    return entidadeEmail;
            _entidadeEmailRepository.Add(entidadeEmail);
            return entidadeEmail;
        }
        public EntidadeEmail EntidadeEmailAtualizar(EntidadeEmail entidadeEmail)
        {
            return _entidadeEmailRepository.Update(entidadeEmail);
        }
        public void DeleteEntidadeEmail(Guid id)
        {
            _entidadeEmailRepository.Delete(id);
        }
        //Telefone
        public EntidadeTelefone EntidadeTelefoneAdicionar(EntidadeTelefone entidadeTelefone)
        {
            //if (!entidadeTelefone.IsValid())
            //    return entidadeTelefone;
            _entidadeTelefoneRepository.Add(entidadeTelefone);
            return entidadeTelefone;
        }
        public EntidadeTelefone EntidadeTelefoneAtualizar(EntidadeTelefone entidadeTelefone)
        {
            return _entidadeTelefoneRepository.Update(entidadeTelefone);
        }
        public void DeleteEntidadeTelefone(Guid id)
        {
            _entidadeTelefoneRepository.Delete(id);
        }

        public void Dispose()
        {
            _entidadeRepository.Dispose();
            _entidadeEmailRepository.Dispose();
            _entidadeTelefoneRepository.Dispose();
            _entidadeEnderecoRepository.Dispose();
        }
    }
}
