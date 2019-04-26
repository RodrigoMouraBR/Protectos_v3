using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraTelefoneViewModel
    {
        public Guid Id { get; set; }
        public string Prefixo { get; set; }
        public string Numero { get; set; }
        public string TipoTelefone { get; set; }
        public Guid CorretoraId { get; set; }
        public virtual CorretoraViewModel Corretora { get; set; }
    }
}
