﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Protectos.Application.ViewModels.Clientes
{
    public class ClienteTelefoneViewModel
    {
        public ClienteTelefoneViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Prefixo")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Prefixo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Numero")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Preencha o campo Tipo")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Tipo Telefone")]
        public string TipoTelefone { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public Guid ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
