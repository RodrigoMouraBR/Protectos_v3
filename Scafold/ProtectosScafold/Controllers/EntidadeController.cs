using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Protectos.Application.Interfaces.Entidades;
using Protectos.Application.ViewModels.Entidades;
using ProtectosScafold.Models;

namespace ProtectosScafold.Controllers
{
    public class EntidadeController : Controller
    {
        private readonly IEntidadeApplicationService _entidadeApplicationService;
        public EntidadeController(IEntidadeApplicationService entidadeApplicationService)
        {
            _entidadeApplicationService = entidadeApplicationService;
        }        
        public ActionResult Index()
        {
            return View(_entidadeApplicationService.EntidadeObterTodos());
        }        
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeViewModel entidadeViewModel = _entidadeApplicationService.EntidadeObterPorId(id.Value);
            if (entidadeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(entidadeViewModel);
        }       
        public ActionResult Create()
        {
            return View();
        }       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntidadeViewModel entidadeViewModel)
        {
            if (ModelState.IsValid)
            {               
                return RedirectToAction("Index");
            }

            return View(entidadeViewModel);
        }       
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeViewModel entidadeViewModel = _entidadeApplicationService.EntidadeObterPorId(id.Value);
            if (entidadeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(entidadeViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EntidadeViewModel entidadeViewModel)
        {
            if (ModelState.IsValid)
            {                
                return RedirectToAction("Index");
            }
            return View(entidadeViewModel);
        }       
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeViewModel entidadeViewModel = _entidadeApplicationService.EntidadeObterPorId(id.Value);
            if (entidadeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(entidadeViewModel);
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
                _entidadeApplicationService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
