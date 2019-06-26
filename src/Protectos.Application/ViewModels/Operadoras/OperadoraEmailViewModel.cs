using Protectos.Application.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraEmailViewModel
    {
        public OperadoraEmailViewModel()
        {
            EmailId = Guid.NewGuid();
        }
        [Key]
        public Guid EmailId { get; set; }
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
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Tipo Email")]
        public ETipoEmailEmpresa TipoEmail { get; set; }
        [ScaffoldColumn(false)]
        public Guid OperadoraId { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}