﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraViewModel
    {
        public OperadoraViewModel()
        {
            Id = Guid.NewGuid();
           
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]       
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]       
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]        
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Inscricao Estadual")]
        public string InscricaoEstadual { get; set; }
        [DisplayName("Inscricao Estadual")]
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<OperadoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<OperadoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<OperadoraEmailViewModel> Emails { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
