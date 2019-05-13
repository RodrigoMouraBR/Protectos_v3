using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       
        public string Prefixo { get; set; }
       
        public string Numero { get; set; }
      
        public string TipoTelefone { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public Guid CorretoraId { get; set; }
        public virtual CorretoraViewModel Corretora { get; set; }
    }
}
