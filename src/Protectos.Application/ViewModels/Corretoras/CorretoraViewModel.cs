

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
        [Required(ErrorMessage = "Preencha o campo Nome")]       
        [DisplayName("Razão")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]        
        [DisplayName("Fantasia")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]        
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Inscricao Estadual")]
        public string InscricaoEstadual { get; set; }
        [DisplayName("Inscricao Municipal")]
        public string InscricaoMunicipal { get; set; }
        [DisplayName("WebPager")]
        public string Site { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]        
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<CorretoraEnderecoViewModel> Enderecos { get; set; }
        public virtual IEnumerable<CorretoraTelefoneViewModel> Telefones { get; set; }
        public virtual IEnumerable<CorretoraEmailViewModel> Emails { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
