using System;
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
            Enderecos = new List<OperadoraEnderecoViewModel>();
            Telefones = new List<OperadoraTelefoneViewModel>();
            Emails = new List<OperadoraEmailViewModel>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
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
