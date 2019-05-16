using System;
using System.ComponentModel.DataAnnotations;
namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeEnderecoViewModel
    {
        public EntidadeEnderecoViewModel()
        {
            Id = Guid.NewGuid();
            Ativo = true;
        }
        public Guid Id { get; set; }
      
        public string Logradouro { get; set; }
      
        public string Numero { get; set; }
      
        public string Bairro { get; set; }
       
        public string Cep { get; set; }
       
        public string Complemento { get; set; }
       
        public string Cidade { get; set; }
        
        public string Estado { get; set; }
        
        public string UF { get; set; }
       
        public string Pais { get; set; }
        [ScaffoldColumn(false)]
        public Guid AdministradoraId { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        public virtual EntidadeViewModel Administradora { get; set; }
    }
}
