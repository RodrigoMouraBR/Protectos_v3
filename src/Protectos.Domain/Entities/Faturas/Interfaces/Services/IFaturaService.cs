using System;
namespace Protectos.Domain.Entities.Faturas.Interfaces.Interfaces.Services
{
    public interface IFaturaService : IDisposable
    {
        Fatura FaturaAdicionar(Fatura entidadeEmail);
        Fatura FaturaAtualizar(Fatura entidadeEmail);
        void DeleteFatura(Guid id);
    }
}
