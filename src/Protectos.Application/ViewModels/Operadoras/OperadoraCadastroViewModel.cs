using Protectos.Infra.CrossCutting.MvcFilters;
using System.ComponentModel.DataAnnotations;
using System.Web;
namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraCadastroViewModel
    {
        public OperadoraViewModel Operadora { get; set; }
        public OperadoraEnderecoViewModel Endereco { get; set; }
        public OperadoraEmailViewModel Email { get; set; }
        public OperadoraTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
