using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeEmailViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string TipoEmail { get; set; }
        public Guid AdministradoraId { get; set; }
        public virtual EntidadeViewModel Administradora { get; set; }
    }
}
