using Protectos.Application.Interfaces.Fatura;
using Protectos.Application.ViewModels.Faturas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
    {


        public class FaturaController : Controller
        {
            private readonly IFaturaApplicationService _faturaApplicationService;
            public FaturaController(IFaturaApplicationService faturaApplicationService)
            {
                _faturaApplicationService = faturaApplicationService;
            }
            public ActionResult Index()
            {
                return View(_faturaApplicationService.FaturaObterTodos());
            }
            public ActionResult Details(Guid? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                FaturaViewModel faturaViewModel = _faturaApplicationService.FaturaObterPorId(id.Value);
                if (faturaViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(faturaViewModel);
            }
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(FaturaViewModel faturaViewModel)
            {
                if (ModelState.IsValid)
                {
                    _faturaApplicationService.FaturaAdicionar(faturaViewModel);
                    return RedirectToAction("Index");
                }
                return View(faturaViewModel);
            }
            public ActionResult Edit(Guid? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                FaturaViewModel faturaViewModel = _faturaApplicationService.FaturaObterPorId(id.Value);
                if (faturaViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(faturaViewModel);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(FaturaViewModel faturaViewModel)
            {
                if (ModelState.IsValid)
                {
                    _faturaApplicationService.FaturaAdicionar(faturaViewModel);
                    return RedirectToAction("Index");
                }
                return View(faturaViewModel);
            }
            public ActionResult Delete(Guid? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var faturaViewModel = _faturaApplicationService.FaturaObterPorId(id.Value);
                if (faturaViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(faturaViewModel);
            }
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(Guid id)
            {
                _faturaApplicationService.DeleteFatura(id);
                return RedirectToAction("Index");
            }
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    _faturaApplicationService.Dispose();
                }
                base.Dispose(disposing);
            }
          
        }

}