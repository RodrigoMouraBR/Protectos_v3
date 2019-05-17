using System;
using System.ComponentModel.DataAnnotations;
namespace Protectos.Application.ViewModels.Clientes
{
    public class ClienteEnderecoViewModel
    {
        public ClienteEnderecoViewModel()
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
        public Guid ClienteId { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; protected set; }
        [ScaffoldColumn(false)]
        public Guid CadastradoPor { get; protected set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; protected set; }
        [ScaffoldColumn(false)]
        public Guid AlteradoPor { get; protected set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
