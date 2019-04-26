using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraEmailViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string TipoEmail { get; set; }
        public Guid CorretoraId { get; set; }
        public virtual CorretoraViewModel Corretora { get; set; }
    }
}
