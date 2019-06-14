using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioDependenteViewModel
    {
        public BeneficiarioDependenteViewModel()
        {
            DependenteId = Guid.NewGuid();
        }
        [Key]
        public Guid DependenteId { get; set; }
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
        [DisplayName("Nome")]
        public string Nome { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Sexo { get; private set; }        
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("CPF")]
        public string Cpf { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("RG")]
        public string RG { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEmissaoRG { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string OrgaoEmissor { get; private set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string EstadoCivil { get; private set; }
        [ScaffoldColumn(false)]
        public Guid BeneficiarioId { get; set; }
        public virtual BeneficiarioViewModel Beneficiario { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
