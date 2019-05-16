using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeTelefoneViewModel
    {
        public EntidadeTelefoneViewModel()
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
        public Guid AdministradoraId { get; set; }
        public virtual EntidadeViewModel Administradora { get; set; }
    }
}
