using Protectos.Infra.CrossCutting.MvcFilters;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraCadastroViewModel
    {
        public CorretoraViewModel Corretora { get; set; }
        public CorretoraEnderecoViewModel Endereco { get; set; }
        public CorretoraEmailViewModel Email { get; set; }
        public CorretoraTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
