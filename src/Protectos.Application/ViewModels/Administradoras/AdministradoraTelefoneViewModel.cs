using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraTelefoneViewModel
    {
        public Guid Id { get; set; }
        public string Prefixo { get; set; }
        public string Numero { get; set; }
        public string TipoTelefone { get; set; }
        public Guid AdministradoraId { get; set; }
        public virtual AdministradoraViewModel Administradora { get; set; }
    }
}
