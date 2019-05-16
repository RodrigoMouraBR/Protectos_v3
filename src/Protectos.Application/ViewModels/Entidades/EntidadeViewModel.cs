using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeViewModel
    {
        public EntidadeViewModel()
        {
            Id = Guid.NewGuid();           
        }
        [Key]
        public Guid Id { get; set; }
       
        public string RazaoSocial { get; set; }
       
        public string NomeFantasia { get; set; }
      
        public string Cnpj { get; set; }
       
        public string InscricaoEstadual { get; set; }
       
        public string InscricaoMunicipal { get; set; }
        public string Site { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<EntidadeEnderecoViewModel> Enderecos { get; set; }
        public virtual ICollection<EntidadeTelefoneViewModel> Telefones { get; set; }
        public virtual ICollection<EntidadeEmailViewModel> Emails { get; set; }

        //[ScaffoldColumn(false)]
        //public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
