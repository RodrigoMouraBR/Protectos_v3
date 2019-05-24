using System;
using Protectos.Domain.Entities.Faturas.Interfaces.Interfaces.Services;
using Protectos.Domain.Entities.Faturas.Interfaces.Repositories;
namespace Protectos.Domain.Entities.Faturas.Services
{
    public class FaturaService : IFaturaService
    {
        private readonly IFaturaRepository _faturaRepository;
        public FaturaService(IFaturaRepository faturaRepository)
        {
            _faturaRepository = faturaRepository;
        }
        public void DeleteFatura(Guid id)
        {
            _faturaRepository.Delete(id);
        }
        public Fatura FaturaAdicionar(Fatura entidadeEmail)
        {
            //if (!entidadeEmail.IsValid())
            //    return entidadeEmail;
            _faturaRepository.Add(entidadeEmail);
            return entidadeEmail;
        }
        public Fatura FaturaAtualizar(Fatura entidadeEmail)
        {
            //if (!entidadeEmail.IsValid())
            //    return entidadeEmail;
            _faturaRepository.Update(entidadeEmail);
            return entidadeEmail;
        }

        public void Dispose()
        {
            _faturaRepository.Dispose();            
        }
    }
}
