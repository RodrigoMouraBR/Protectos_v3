using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraEmailViewModel
    {
        public CorretoraEmailViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Prefixo")]       
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o campo Tipo")]        
        [DisplayName("Tipo Email")]
        public string TipoEmail { get; set; }
        [ScaffoldColumn(false)]
        public Guid CorretoraId { get; set; }
        public virtual CorretoraViewModel Corretora { get; set; }
    }
}
