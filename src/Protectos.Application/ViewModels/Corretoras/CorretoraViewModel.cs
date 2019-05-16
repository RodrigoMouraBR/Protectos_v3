using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraViewModel
    {
        public CorretoraViewModel()
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
        public virtual ICollection<CorretoraEnderecoViewModel> Enderecos { get; set; }
        public virtual ICollection<CorretoraTelefoneViewModel> Telefones { get; set; }
        public virtual ICollection<CorretoraEmailViewModel> Emails { get; set; }

        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
