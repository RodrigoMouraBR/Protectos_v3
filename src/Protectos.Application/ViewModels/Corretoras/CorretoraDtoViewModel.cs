using Protectos.Infra.CrossCutting.MvcFilters;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraDtoViewModel
    {        
        public CorretoraViewModel Corretora { get; private set; }
        public CorretoraEnderecoViewModel Endereco { get; private set; }
        public CorretoraEmailViewModel Email { get; private set; }
        public CorretoraTelefoneViewModel Telefone { get; private set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
