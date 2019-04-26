using System.Collections.Generic;
using System.Linq;
using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
namespace Protectos.Infra.Data.Repositories.Beneficiarios
{
    public class BeneficiarioRepository : Repository<Beneficiario>, IBeneficiarioRepository
    {
        public BeneficiarioRepository(ProtectosContext protectosContext) : base(protectosContext)
        {

        }
        public IEnumerable<Beneficiario> ObterBeneficiarioAtivo()
        {
            return Search(b => b.Ativo == true).ToList();
        }
        public IEnumerable<Beneficiario> ObterBeneficiarioInativo()
        {
            return Search(b => b.Ativo == false).ToList();
        }
        public Beneficiario ObterBeneficiarioPorCpf(string cpf)
        {
            return Search(b => b.Cpf.Numero == cpf).FirstOrDefault();
        }
    }
}
