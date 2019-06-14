using Protectos.Infra.CrossCutting.MvcFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Protectos.Application.ViewModels.Clientes
{
    public class ClienteCadastroViewModel
    {
        public ClienteViewModel Administradora { get; set; }
        public ClienteEnderecoViewModel Endereco { get; set; }
        public ClienteEmailViewModel Email { get; set; }
        public ClienteTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
