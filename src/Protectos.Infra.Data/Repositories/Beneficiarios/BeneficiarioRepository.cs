using Protectos.Domain.Entities.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Generics.Repositories;
using System.Collections.Generic;
using System.Linq;
namespace Protectos.Infra.Data.Repositories.Beneficiarios
{
    public class BeneficiarioRepository : Repository<Beneficiario>, IBeneficiarioRepository
    {
        public BeneficiarioRepository(ProtectosContext protectosContext) : base(protectosContext)
        {
        }
        public IEnumerable<Beneficiario> BeneficiarioObterAtivo()
        {
            return Search(b => b.Ativo == true).ToList();
        }
        public IEnumerable<Beneficiario> BeneficiarioObterInativo()
        {
            return Search(b => b.Ativo == false).ToList();
        }
        public Beneficiario BeneficiarioObterPorCpf(string cpf)
        {

            return Search(b => b.Cpf == cpf).FirstOrDefault();
        }       
    }
}
