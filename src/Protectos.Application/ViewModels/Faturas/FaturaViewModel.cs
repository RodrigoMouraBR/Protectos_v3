using Protectos.Application.ViewModels.Configuracoes;
using Protectos.Application.ViewModels.Entidades;
using Protectos.Application.ViewModels.Operadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Faturas
{
    public class FaturaViewModel
    {
        public FaturaViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeFatura { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NumeroFatura { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int MesReajuste { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int DiaVigencia { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int VencimentoBoleto { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int VencimentoDBA { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int PermiteCobrancaDobrada { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        public decimal TaxaJuros { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        public decimal TaxaMulta { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        public decimal TaxaBancaria { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string FaturaCaracteristicaTipo { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string FaturaTipo { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public bool AjustaPrecoMesAniversario { get; set; }
        [ScaffoldColumn(false)]
        public string Status { get; set; }
        public Guid EntidadeId { get; set; }
        public Guid OperadoraId { get; set; }
        public virtual EntidadeViewModel Entidade { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }

        public virtual ICollection<RelacaoFaturaPlanoViewModel> FaturaPlano { get; set; }
    }
}
