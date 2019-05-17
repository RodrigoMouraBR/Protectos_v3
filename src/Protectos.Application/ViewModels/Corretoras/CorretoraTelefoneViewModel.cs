using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraTelefoneViewModel
    {
        public CorretoraTelefoneViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Prefixo")]       
        public string Prefixo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Numero")]       
        public string Numero { get; set; }
        [Required(ErrorMessage = "Preencha o campo Tipo")]       
        [DisplayName("Tipo Telefone")]
        public string TipoTelefone { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public Guid CorretoraId { get; set; }
        public virtual CorretoraViewModel Corretora { get; set; }
    }
}
