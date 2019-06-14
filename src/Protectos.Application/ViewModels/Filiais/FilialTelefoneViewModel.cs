﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Filiais
{
    public class FilialTelefoneViewModel
    {
        public FilialTelefoneViewModel()
        {
            TelefoneId = Guid.NewGuid();
        }
        [Key]
        public Guid TelefoneId { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; set; }
        [ScaffoldColumn(false)]
        public string AlteradoPor { get; set; }
        [Required(ErrorMessage = "Preencha o campo Prefixo")]
        [MaxLength(5, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Prefixo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Prefixo")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Numero { get; set; }
        [DisplayName("Tipo Telfone")]
        public string TipoTelefone { get; set; }
        [ScaffoldColumn(false)]
        public Guid FilialId { get; set; }
        public virtual FilialViewModel Filial { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
