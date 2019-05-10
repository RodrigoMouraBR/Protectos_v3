using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;
using System;
using System.Net;
using System.Web.Mvc;
namespace ProtectosScafold.Controllers
{
    public class AdministradorasController : Controller
    {
        private readonly IAdministradoraApplicationService _administradoraApplicationService;

        public AdministradorasController(IAdministradoraApplicationService administradoraApplicationService)
        {
            _administradoraApplicationService = administradoraApplicationService;
        }
        public ActionResult Index()
        {
            return View(_administradoraApplicationService.AdministradoraObterTodos());
        }
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var administradoraViewModel = _administradoraApplicationService.AdministradoraObterPorId(id.Value);
            if (administradoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(administradoraViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdministradoraViewModel administradoraViewModel)
        {
            if (ModelState.IsValid)
            {
                administradoraViewModel = _administradoraApplicationService.AdministradoraAdicionar(administradoraViewModel);
                if (administradoraViewModel.ValidationResult.IsValid)
                {
                    foreach (var error in administradoraViewModel.ValidationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.ErrorMessage);
                    }
                    return View(administradoraViewModel);
                }
                return RedirectToAction("Index");
            }
            return View(administradoraViewModel);
        }        
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var administradoraViewModel = _administradoraApplicationService.AdministradoraObterPorId(id.Value);
            if (administradoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(administradoraViewModel);
        }       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdministradoraViewModel administradoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _administradoraApplicationService.AdministradoraAtualizar(administradoraViewModel);
                return RedirectToAction("Index");
            }
            return View(administradoraViewModel);
        }        
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var administradoraViewModel = _administradoraApplicationService.AdministradoraObterPorId(id.Value);
            if (administradoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(administradoraViewModel);
        }       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _administradoraApplicationService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
