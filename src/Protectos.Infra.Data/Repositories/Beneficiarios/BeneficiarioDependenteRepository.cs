using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System.Collections.Generic;
using System.Linq;
namespace Protectos.Infra.Data.Repositories.Beneficiarios
{
    public class BeneficiarioDependenteRepository : Repository<BeneficiarioDependente>, IBeneficiarioDependenteRepository
    {
        public BeneficiarioDependenteRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<BeneficiarioDependente> BeneficiarioDependenteObterAtivo()
        {
            return Search(b => b.Ativo == true).ToList();
        }
        public IEnumerable<BeneficiarioDependente> BeneficiarioDependenteObterInativo()
        {
            return Search(b => b.Ativo == false).ToList();
        }
        public BeneficiarioDependente BeneficiarioDependenteObterPorCpf(string cpf)
        {
            return Search(b => b.Cpf.Numero == cpf).FirstOrDefault();
        }
    }
}
