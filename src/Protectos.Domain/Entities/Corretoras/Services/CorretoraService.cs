﻿using Protectos.Domain.Entities.Corretoras.Interfaces.Repositories;
using System;
namespace Protectos.Domain.Entities.Corretoras.Services
{
    public class CorretoraService
    {
        private readonly ICorretoraRepository _CorretoraRepository;
        private readonly ICorretoraEmailRepository _CorretoraEmailRepository;
        private readonly ICorretoraTelefoneRepository _CorretoraTelefoneRepository;
        private readonly ICorretoraEnderecoRepository _CorretoraEnderecoRepository;
        public CorretoraService(ICorretoraRepository CorretoraRepository,
                                     ICorretoraEmailRepository CorretoraEmailRepository,
                                     ICorretoraTelefoneRepository CorretoraTelefoneRepository,
                                     ICorretoraEnderecoRepository CorretoraEnderecoRepository)
        {
            _CorretoraRepository = CorretoraRepository;
            _CorretoraEmailRepository = CorretoraEmailRepository;
            _CorretoraTelefoneRepository = CorretoraTelefoneRepository;
            _CorretoraEnderecoRepository = CorretoraEnderecoRepository;
        }
        //Corretora
        public Corretora CorretoraAdicionar(Corretora Corretora)
        {
            if (!Corretora.IsValid())
                return Corretora;
            _CorretoraRepository.Add(Corretora);
            return Corretora;
        }
        public Corretora CorretoraAtualizar(Corretora Corretora)
        {
            return _CorretoraRepository.Update(Corretora);
        }
        public void DeleteCorretora(Guid id)
        {
            throw new NotImplementedException();
        }
        //Endereco
        public CorretoraEndereco CorretoraEnderecoAdicionar(CorretoraEndereco corretoraEndereco)
        {
            if (!corretoraEndereco.IsValid())
                return corretoraEndereco;
            _CorretoraEnderecoRepository.Add(corretoraEndereco);
            return corretoraEndereco;
        }
        public CorretoraEndereco CorretoraEnderecoAtualizar(CorretoraEndereco corretoraEndereco)
        {
            return _CorretoraEnderecoRepository.Update(corretoraEndereco);
        }
        public void DeleteCorretoraEndereco(Guid id)
        {
            throw new NotImplementedException();
        }
        //Email
        public CorretoraEmail CorretoraEmailAdicionar(CorretoraEmail corretoraEmail)
        {
            if (!corretoraEmail.IsValid())
                return corretoraEmail;
            _CorretoraEmailRepository.Add(corretoraEmail);
            return corretoraEmail;
        }
        public CorretoraEmail CorretoraEmailAtualizar(CorretoraEmail corretoraEmail)
        {
            return _CorretoraEmailRepository.Update(corretoraEmail);
        }
        public void DeleteCorretoraEmail(Guid id)
        {
            throw new NotImplementedException();
        }
        //Telefone
        public CorretoraTelefone CorretoraTelefoneAdicionar(CorretoraTelefone corretoraTelefone)
        {
            if (!corretoraTelefone.IsValid())
                return corretoraTelefone;
            _CorretoraTelefoneRepository.Add(corretoraTelefone);
            return corretoraTelefone;
        }
        public CorretoraTelefone CorretoraTelefoneAtualizar(CorretoraTelefone corretoraTelefone)
        {
            return _CorretoraTelefoneRepository.Update(corretoraTelefone);
        }
        public void DeleteCorretoraTelefone(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
