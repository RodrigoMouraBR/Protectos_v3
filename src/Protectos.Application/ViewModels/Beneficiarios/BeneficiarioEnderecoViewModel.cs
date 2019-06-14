using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioEnderecoViewModel
    {
        public BeneficiarioEnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }
        [Key]
        public Guid EnderecoId { get; set; }
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
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Numero")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CEP")]
        public string Cep { get; set; }
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Complemento")]
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("UF")]
        public string UF { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("País")]
        public string Pais { get; set; }
        [ScaffoldColumn(false)]
        public Guid BeneficiarioId { get; set; }
        public virtual BeneficiarioViewModel Beneficiario { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}