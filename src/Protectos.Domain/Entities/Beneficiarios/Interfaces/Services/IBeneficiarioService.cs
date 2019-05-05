﻿using System;
namespace Protectos.Domain.Entities.Beneficiarios.Interfaces.Services
{
    public interface IBeneficiarioService
    {
        Beneficiario BeneficiarioAdicionar(Beneficiario beneficiario);
        Beneficiario BeneficiarioAtualizar(Beneficiario beneficiario);
        void BeneficiarioDelete(Guid id);

        BeneficiarioDependente BeneficiarioDependenteAtualizar(BeneficiarioDependente beneficiarioDependente);
        BeneficiarioDependente BeneficiarioDependenteAdicionar(BeneficiarioDependente beneficiarioDependente);
        void BeneficiarioDependenteDelete(Guid id);

        BeneficiarioEndereco BeneficiarioEnderecoAdicionar(BeneficiarioEndereco beneficiarioEndereco);
        BeneficiarioEndereco BeneficiarioEnderecoAtualizar(BeneficiarioEndereco beneficiarioEndereco);
        void BeneficiarioEnderecoDelete(Guid id);

        BeneficiarioTelefone BeneficiarioTelefoneAdicionar(BeneficiarioTelefone beneficiarioTelefone);
        BeneficiarioTelefone BeneficiarioTelefoneAtualizar(BeneficiarioTelefone beneficiarioTelefone);
        void BeneficiariTelefoneDelete(Guid id);
    }
}
