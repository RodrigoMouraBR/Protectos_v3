using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;
using ProtectosScafold.Models;

namespace ProtectosScafold.Controllers
{
    public class AdministradoraController : BaseController
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
            administradoraViewModel = _administradoraApplicationService.AdministradoraAdicionar(administradoraViewModel);
            if (!administradoraViewModel.ValidationResult.IsValid)
            {
                foreach (var erro in administradoraViewModel.ValidationResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, erro.ErrorMessage);
                }
                return View(administradoraViewModel);
            }
            if (administradoraViewModel.ValidationResult.ToString() != string.Empty)
            {
                ViewBag.Sucesso = administradoraViewModel.ValidationResult.Errors.ToList();
                return View(administradoraViewModel);
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
            //_administradoraApplicationService.
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
