using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
{
    public class AdministradoraController : BaseController
    {
        // GET: Administradora
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {

            return View();
        }
        public ActionResult Edit()
        {

            return View();
        }


    }
}