using Protectos.Application.Interfaces.Administradoras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
{

    public class AdministradoraController : Controller
    {
        private readonly IAdministradoraApplicationService _administradoraApplicationService;

        public AdministradoraController(IAdministradoraApplicationService administradoraApplicationService)
        {
            _administradoraApplicationService = administradoraApplicationService;         

        }



        public ActionResult Index()
        {
            return View(_administradoraApplicationService.AdministradoraObterTodos());
        }

        [Route("novo")]
        public ActionResult Incluir()
        {
            return View();
        }

    }
}