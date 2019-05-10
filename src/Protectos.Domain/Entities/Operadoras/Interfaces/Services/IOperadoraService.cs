using System;

namespace Protectos.Domain.Entities.Operadoras.Interfaces.Services
{
    public interface IOperadoraService : IDisposable
    {
        Operadora OperadoraAdicionar(Operadora operadora);
        Operadora OperadoraAtualizar(Operadora operadora);
        void DeleteOperadora(Guid id);

        //Email
        OperadoraEmail OperadoraEmailAdicionar(OperadoraEmail operadoraEmail);
        OperadoraEmail OperadoraEmailAtualizar(OperadoraEmail operadoraEmail);
        void DeleteOperadoraEmail(Guid id);

        //Telefone
        OperadoraTelefone OperadoraTelefoneAdicionar(OperadoraTelefone operadoraTelefone);
        OperadoraTelefone OperadoraTelefoneAtualizar(OperadoraTelefone operadoraTelefone);
        void DeleteOperadoraTelefone(Guid id);

        //Endereco
        OperadoraEndereco OperadoraEnderecoAdicionar(OperadoraEndereco operadoraEndereco);
        OperadoraEndereco OperadoraEnderecoAtualizar(OperadoraEndereco operadoraEndereco);
        void DeleteOperadoraEndereco(Guid id);
    }
}
