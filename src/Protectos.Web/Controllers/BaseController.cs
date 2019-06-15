using Protectos.Infra.CrossCutting.ExternalService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
{
    public class BaseController : Controller
    {
        public const int PageSize = 5;

        public ActionResult ObterEmpresaPorCnpj(string id)
        {
            ReceitawsExternalService receita = new ReceitawsExternalService();
            var empresa = receita.ConsultaJsonUnitario(id);                     

            return Json(new { data = empresa}, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObterEnderecoPorCep(string cep)
        {
            return Json(new { foo = "bar", baz = "Blech" });
        }


    }
}