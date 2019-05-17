using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Beneficiarios
{
    public class BeneficiarioEmailViewModel
    {
        public BeneficiarioEmailViewModel()
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
        public Guid BeneficiarioId { get; set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; protected set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; protected set; }
        [ScaffoldColumn(false)]
        public Guid AlteradoPor { get; protected set; }
        public virtual BeneficiarioViewModel Beneficiario { get; set; }
    }
}