using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeEmailViewModel
    {
        public EntidadeEmailViewModel()
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
