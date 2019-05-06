using Protectos.Domain.Generics.Interfaces;
using System.Collections.Generic;
namespace Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories
{
    public interface IBeneficiarioDependenteRepository : IRepository<BeneficiarioDependente>
    {
        BeneficiarioDependente BeneficiarioDependenteObterPorCpf(string cpf);
        IEnumerable<BeneficiarioDependente> BeneficiarioDependenteObterAtivo();
        IEnumerable<BeneficiarioDependente> BeneficiarioDependenteObterInativo();
    }
}