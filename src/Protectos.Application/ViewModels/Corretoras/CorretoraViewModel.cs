using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraViewModel
    {
        public CorretoraViewModel()
        {
            Id = Guid.NewGuid();
            Enderecos = new List<CorretoraEnderecoViewModel>();
            Telefones = new List<CorretoraTelefoneViewModel>();
            Emails = new List<CorretoraEmailViewModel>();
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
        public virtual IEnumerable<CorretoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<CorretoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<CorretoraEmailViewModel> Emails { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
