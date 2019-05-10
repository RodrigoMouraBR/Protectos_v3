using System;
namespace Protectos.Domain.Entities.Entidades.Interfaces.Services
{
    public interface IEntidadeService : IDisposable
    {
        Entidade EntidadeAdicionar(Entidade entidade);
        Entidade EntidadeAtualizar(Entidade entidade);
        void DeleteEntidade(Guid id);

        //Email
        EntidadeEmail EntidadeEmailAdicionar(EntidadeEmail entidadeEmail);
        EntidadeEmail EntidadeEmailAtualizar(EntidadeEmail entidadeEmail);
        void DeleteEntidadeEmail(Guid id);

        //Telefone
        EntidadeTelefone EntidadeTelefoneAdicionar(EntidadeTelefone entidadeTelefone);
        EntidadeTelefone EntidadeTelefoneAtualizar(EntidadeTelefone entidadeTelefone);
        void DeleteEntidadeTelefone(Guid id);

        //Endereco
        EntidadeEndereco EntidadeEnderecoAdicionar(EntidadeEndereco entidadeEndereco);
        EntidadeEndereco EntidadeEnderecoAtualizar(EntidadeEndereco entidadeEndereco);
        void DeleteEntidadeEndereco(Guid id);
    }
}
