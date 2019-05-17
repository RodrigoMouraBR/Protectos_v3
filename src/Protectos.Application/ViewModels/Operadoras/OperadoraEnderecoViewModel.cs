using System;
using System.ComponentModel.DataAnnotations;

namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraEnderecoViewModel
    {
        public OperadoraEnderecoViewModel()
        {
            Id = Guid.NewGuid();
            Ativo = true;
        }
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Logradouro")]       
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Preencha o campo Numero")]       
        public string Numero { get; set; }
        [Required(ErrorMessage = "Preencha o campo Bairro")]        
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Preencha o campo CEP")]        
        public string Cep { get; set; }        
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Preencha o campo Cidade")]       
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Preencha o campo Estado")]       
        public string Estado { get; set; }
        [Required(ErrorMessage = "Preencha o campo UF")]        
        public string UF { get; set; }
        [Required(ErrorMessage = "Preencha o campo País")]       
        public string Pais { get; set; }
        [ScaffoldColumn(false)]
        public Guid OperadoraId { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        public virtual OperadoraViewModel Operadora { get; set; }
    }
}