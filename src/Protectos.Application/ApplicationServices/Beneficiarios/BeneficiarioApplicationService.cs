using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Domain.Entities.Beneficiarios.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ApplicationServices.Beneficiarios
{
    public class BeneficiarioApplicationService : IBeneficiarioApplicationService
    {
        private IBeneficiarioRepository _beneficiarioRepository;
        public BeneficiarioApplicationService(IBeneficiarioRepository beneficiarioRepository)
        {
            _beneficiarioRepository = beneficiarioRepository;
        }
    }
}
