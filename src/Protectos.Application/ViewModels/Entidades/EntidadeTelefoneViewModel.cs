using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeTelefoneViewModel
    {
        public Guid Id { get; set; }
        public string Prefixo { get; set; }
        public string Numero { get; set; }
        public string TipoTelefone { get; set; }
        public Guid AdministradoraId { get; set; }
        public virtual EntidadeViewModel Administradora { get; set; }
    }
}
