﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioViewModel
    {
        public BeneficiarioViewModel()
        {
            Id = Guid.NewGuid();
            BeneficiarioEndereco = new List<BeneficiarioEnderecoViewModel>();
            BeneficiarioTelefone = new List<BeneficiarioTelefoneViewModel>();
            BeneficiarioEmail = new List<BeneficiarioEmailViewModel>();           
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public string EstadoCivil { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; protected set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; protected set; }
        [ScaffoldColumn(false)]
        public Guid AlteradoPor { get; protected set; }
        public virtual ICollection<BeneficiarioEnderecoViewModel> BeneficiarioEndereco { get; set; }
        public virtual ICollection<BeneficiarioTelefoneViewModel> BeneficiarioTelefone { get; set; }
        public virtual ICollection<BeneficiarioEmailViewModel> BeneficiarioEmail { get; set; }        

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
