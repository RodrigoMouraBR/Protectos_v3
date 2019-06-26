using Protectos.Infra.CrossCutting.MvcFilters;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Protectos.Application.ViewModels.Entidades
{
    public class EntidadeCadastroViewModel
    {
        public EntidadeViewModel Entidade { get; set; }
        public EntidadeEnderecoViewModel Endereco { get; set; }
        public EntidadeEmailViewModel Email { get; set; }
        public EntidadeTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
