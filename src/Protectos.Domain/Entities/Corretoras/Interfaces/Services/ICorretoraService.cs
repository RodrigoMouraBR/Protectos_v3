using System;
namespace Protectos.Domain.Entities.Corretoras.Interfaces.Services
{
    public interface ICorretoraService : IDisposable
    {
        Corretora CorretoraAdicionar(Corretora corretora);
        Corretora CorretoraAtualizar(Corretora corretora);
        void DeleteCorretora(Guid id);

        //Email
        CorretoraEmail CorretoraEmailAdicionar(CorretoraEmail corretoraEmail);
        CorretoraEmail CorretoraEmailAtualizar(CorretoraEmail corretoraEmail);
        void DeleteCorretoraEmail(Guid id);

        //Telefone
        CorretoraTelefone CorretoraTelefoneAdicionar(CorretoraTelefone corretoraTelefone);
        CorretoraTelefone CorretoraTelefoneAtualizar(CorretoraTelefone corretoraTelefone);
        void DeleteCorretoraTelefone(Guid id);

        //Endereco
        CorretoraEndereco CorretoraEnderecoAdicionar(CorretoraEndereco corretoraEndereco);
        CorretoraEndereco CorretoraEnderecoAtualizar(CorretoraEndereco corretoraEndereco);
        void DeleteCorretoraEndereco(Guid id);
    }
}
