using Protectos.Infra.CrossCutting.MvcFilters;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraCadastroViewModel
    {
        public AdministradoraViewModel Administradora { get; set; }
        public AdministradoraEnderecoViewModel Endereco { get; set; } 
        public AdministradoraEmailViewModel Email { get; set; }
        public AdministradoraTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }

    }
}
