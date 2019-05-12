using System;
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

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Razão")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Fantasia")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Inscricao Estadual")]
        public string InscricaoEstadual { get; set; }
        [DisplayName("Inscricao Municipal")]
        public string InscricaoMunicipal { get; set; }
        [DisplayName("WebPager")]
        public string Site { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get;  set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<AdministradoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<AdministradoraTelefoneViewModel> Telefones { get;  set; }
        public virtual IEnumerable<AdministradoraEmailViewModel> Emails { get;  set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
