using System.Collections.Generic;
using Protectos.Domain.Generics.Interfaces;
namespace Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories
{
    public interface IBeneficiarioRepository : IRepository<Beneficiario>
    {
        Beneficiario BeneficiarioObterPorCpf(string cpf);
        IEnumerable<Beneficiario> BeneficiarioObterAtivo();
        IEnumerable<Beneficiario> BeneficiarioObterInativo();
    }
}