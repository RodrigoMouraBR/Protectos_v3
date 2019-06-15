using Protectos.Infra.CrossCutting.MvcFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Protectos.Application.ViewModels.Fornecedores
{
    public class FornecedorCadastroViewModel
    {
        public FornecedorViewModel Administradora { get; set; }
        public FornecedorEnderecoViewModel Endereco { get; set; }
        public FornecedorEmailViewModel Email { get; set; }
        public FornecedorTelefoneViewModel Telefones { get; set; }

        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase Foto { get; set; }
        [ScaffoldColumn(false)]
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
