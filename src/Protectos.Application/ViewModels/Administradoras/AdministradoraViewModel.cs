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
        }
        [Key]
        public Guid Id { get;  set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get;  set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get;  set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get;  set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get;  set; }
        [ScaffoldColumn(false)]
        public string AlteradoPor { get;  set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Razão Social")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(14, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]       
        [DisplayName("Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]       
        [DisplayName("Inscrição Municipal")]
        public string InscricaoMunicipal { get; set; }
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Site")]
        public string Site { get; set; }
        public virtual IEnumerable<AdministradoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<AdministradoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<AdministradoraEmailViewModel> Emails { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
