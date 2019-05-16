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
        
        public string NomeFatura { get; set; }
       
        public string NumeroFatura { get; set; }
       
        public int MesReajuste { get; set; }
       
        public int DiaVigencia { get; set; }
        
        public int VencimentoBoleto { get; set; }
        
        public int VencimentoDBA { get; set; }
        
        public int PermiteCobrancaDobrada { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        public decimal TaxaJuros { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        public decimal TaxaMulta { get; set; }
        [Required(ErrorMessage = "Preencha o campo")]
        public decimal TaxaBancaria { get; set; }
       
        public string FaturaCaracteristicaTipo { get; set; }
       
        public string FaturaTipo { get; set; }
       
        public bool AjustaPrecoMesAniversario { get; set; }
        [ScaffoldColumn(false)]
        public string Status { get; set; }
        [ScaffoldColumn(false)]
        public Guid EntidadeId { get; set; }
        [ScaffoldColumn(false)]
        public Guid OperadoraId { get; set; }
        public virtual EntidadeViewModel Entidade { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }

       // public virtual ICollection<RelacaoFaturaPlanoViewModel> FaturaPlano { get; set; }
    }
}
