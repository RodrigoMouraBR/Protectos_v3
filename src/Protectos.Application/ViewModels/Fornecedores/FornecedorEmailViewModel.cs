using Protectos.Application.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Fornecedores
{
    public class FornecedorEmailViewModel
    {
        public FornecedorEmailViewModel()
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
        public Guid FornecedorId { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
    }
}
