using Protectos.Application.ViewModels.Faturas;
using System;
using System.Collections.Generic;

namespace Protectos.Application.Interfaces.Fatura
{
    public interface IFaturaApplicationService : IDisposable
    {
        FaturaViewModel FaturaObterPorId(Guid id);        
        IEnumerable<FaturaViewModel> FaturaObterTodos();        
        FaturaViewModel FaturaAdicionar(FaturaViewModel faturaViewModel);
        FaturaViewModel FaturaAtualizar(FaturaViewModel faturaViewModel);
        void DeleteFatura(Guid id);

        FaturaViewModel FaturaObterPorNumero(string numeroFatura);
        IEnumerable<FaturaViewModel> FaturaObterAtivo();
        IEnumerable<FaturaViewModel> FaturaObterInativo();
    }
}
