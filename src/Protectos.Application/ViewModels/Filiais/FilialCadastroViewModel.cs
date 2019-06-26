using Protectos.Infra.CrossCutting.MvcFilters;
using System.ComponentModel.DataAnnotations;
using System.Web;
namespace Protectos.Application.ViewModels.Filiais
{
    public class FilialCadastroViewModel
    {
        public FilialViewModel Filial { get; set; }
        public FilialEnderecoViewModel Endereco { get; set; }
        public FilialEmailViewModel Email { get; set; }
        public FilialTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
