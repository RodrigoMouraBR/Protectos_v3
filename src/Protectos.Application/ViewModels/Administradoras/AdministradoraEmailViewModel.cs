using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraEmailViewModel
    {
        public AdministradoraEmailViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Prefixo")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o campo Tipo")]
        [MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Tipo Email")]
        public string TipoEmail { get; set; }
        [ScaffoldColumn(false)]
        public Guid AdministradoraId { get; set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; protected set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; protected set; }
        [ScaffoldColumn(false)]
        public Guid AlteradoPor { get; protected set; }
        public virtual AdministradoraViewModel Administradora { get; set; }
    }
}
