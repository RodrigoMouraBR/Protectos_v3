using System;
using System.Collections.Generic;

namespace Protectos.Domain.Entities.Beneficiarios.Interfaces.Services
{
    public interface IBeneficiarioService : IDisposable
    {
        Beneficiario BeneficiarioAdicionar(Beneficiario beneficiario);
        Beneficiario BeneficiarioAtualizar(Beneficiario beneficiario);
        void BeneficiarioDelete(Guid id);       

        BeneficiarioEndereco BeneficiarioEnderecoAdicionar(BeneficiarioEndereco beneficiarioEndereco);
        BeneficiarioEndereco BeneficiarioEnderecoAtualizar(BeneficiarioEndereco beneficiarioEndereco);
        void BeneficiarioEnderecoDelete(Guid id);

        BeneficiarioTelefone BeneficiarioTelefoneAdicionar(BeneficiarioTelefone beneficiarioTelefone);
        BeneficiarioTelefone BeneficiarioTelefoneAtualizar(BeneficiarioTelefone beneficiarioTelefone);
        void BeneficiariTelefoneDelete(Guid id);

        BeneficiarioEmail BeneficiarioEmailAdicionar(BeneficiarioEmail beneficiarioEmail);
        BeneficiarioEmail BeneficiarioEmailAtualizar(BeneficiarioEmail beneficiarioEmail);
        void BeneficiarioEmailDelete(Guid id);

        
        

    }
}
