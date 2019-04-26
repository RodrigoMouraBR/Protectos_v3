using System.Collections.Generic;
using Protectos.Domain.Generics.Interfaces;

namespace Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories
{
    public interface IBeneficiarioRepository : IRepository<Beneficiario>
    {
         Beneficiario ObterBeneficiarioPorCpf(string cpf);
         IEnumerable<Beneficiario> ObterBeneficiarioAtivo();
         IEnumerable<Beneficiario> ObterBeneficiarioInativo();
    }
}