using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraEnderecoViewModel
    {
        public AdministradoraEnderecoViewModel()
        {
            Id = Guid.NewGuid();            
        }
        [Key]
        public Guid Id { get; set; }        
        public string Logradouro { get; set; }//        
        public string Numero { get; set; }//      
        public string Bairro { get; set; }//      
        public string Cep { get; set; }//       
        public string Complemento { get; set; }       
        public string Cidade { get; set; }     
        public string Estado { get; set; }     
        public string UF { get; set; }       
        public string Pais { get; set; }
        [ScaffoldColumn(false)]
        public Guid AdministradoraId { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        public virtual AdministradoraViewModel Administradora { get; set; }
    }
}
