﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraViewModel
    {
        public AdministradoraViewModel()
        {
            Id = Guid.NewGuid();
            Enderecos = new List<AdministradoraEnderecoViewModel>();
            Telefones = new List<AdministradoraTelefoneViewModel>();
            Emails = new List<AdministradoraEmailViewModel>();
        }     
        [Key]
        public Guid Id { get;  set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string RazaoSocial { get;  set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeFantasia { get;  set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CNPJ")]
        public string Cnpj { get;  set; }        
        [DisplayName("Inscricao Estadual")]
        public string InscricaoEstadual { get;  set; }        
        [DisplayName("Inscricao Estadual")]
        public string InscricaoMunicipal { get;  set; }
        public string Site { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get;  set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<AdministradoraEnderecoViewModel> Enderecos { get; set; }
        public virtual ICollection<AdministradoraTelefoneViewModel> Telefones { get;  set; }
        public virtual ICollection<AdministradoraEmailViewModel> Emails { get;  set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
