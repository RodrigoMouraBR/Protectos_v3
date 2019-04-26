using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraEmailViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }        
        public string TipoEmail { get; set; }
        public Guid AdministradoraId { get; set; }
        public virtual AdministradoraViewModel Administradora { get; set; }
    }
}
