using Protectos.Application.Interfaces.Beneficiarios;
using Protectos.Application.ViewModels.Beneficiarios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
{

    public class BeneficiarioController : BaseController
    {
        private readonly IBeneficiarioApplicationService _beneficiarioApplicationService;

        public BeneficiarioController(IBeneficiarioApplicationService beneficiarioApplicationService)
        {
            _beneficiarioApplicationService = beneficiarioApplicationService;
        }
        public ActionResult Index()
        {
            return View(_beneficiarioApplicationService.BeneficiarioObterAtivo());
        }
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var beneficiarioViewModel = _beneficiarioApplicationService.BeneficiarioObterPorId(id.Value);
            if (beneficiarioViewModel == null)
            {
                return HttpNotFound();
            }
            return View(beneficiarioViewModel);
        }
        public ActionResult Incluir()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Incluir(BeneficiarioViewModel beneficiarioViewModel)
        {
            
            if (ModelState.IsValid)
            {
                var beneficiario = _beneficiarioApplicationService.BeneficiarioAdicionar(beneficiarioViewModel);

                if (!beneficiario.ValidationResult.IsValid)
                {
                    foreach (var erro in beneficiario.ValidationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.ErrorMessage);
                    }
                    return View(beneficiario);
                }
                if (beneficiario.ValidationResult.ToString() != string.Empty)
                {
                    ViewBag.Sucesso = beneficiario.ValidationResult.Errors.ToList();
                    return View(beneficiario);
                }
                return RedirectToAction("Index");
            }
            return View(beneficiarioViewModel);
        }
        public ActionResult Editar(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var administradoraViewModel = _beneficiarioApplicationService.BeneficiarioEmailObterPorId(id.Value);
            if (administradoraViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministradoraId = id;
            return View(administradoraViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(BeneficiarioViewModel beneficiarioViewModel)
        {
            if (ModelState.IsValid)
            {
                _beneficiarioApplicationService.BeneficiarioAtualizar(beneficiarioViewModel);
                return RedirectToAction("Index");
            }
            return View(beneficiarioViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var beneficiarioViewModel = _beneficiarioApplicationService.BeneficiarioObterPorId(id.Value);
            if (beneficiarioViewModel == null)
            {
                return HttpNotFound();
            }
            return View(beneficiarioViewModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
           //TO DO : REGRA PARA INATIVAR BENEFICIARIO
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _beneficiarioApplicationService.Dispose();
            }
            base.Dispose(disposing);
        }

        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_EnderecosList", _beneficiarioApplicationService.BeneficiarioObterPorId(id).BeneficiarioEndereco);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(BeneficiarioEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _beneficiarioApplicationService.BeneficiarioEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Beneficiario", new { id = enderecoViewModel.BeneficiarioId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _beneficiarioApplicationService.BeneficiarioObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(BeneficiarioEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _beneficiarioApplicationService.BeneficiarioEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Beneficiario", new { id = enderecoViewModel.BeneficiarioId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarEndereco", enderecoViewModel);
        }
        public ActionResult DeletarEndereco(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var enderecoViewModel = _beneficiarioApplicationService.BeneficiarioEnderecoObterPorId(id.Value);
            if (enderecoViewModel == null)
            {
                return HttpNotFound();
            }
            return PartialView("_DeletarEndereco", enderecoViewModel);
        }
        [HttpPost, ActionName("DeletarEndereco")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarEnderecoConfirmed(Guid id)
        {
            var administradoraId = _beneficiarioApplicationService.BeneficiarioEnderecoObterPorId(id).BeneficiarioId;
            //TO DO : REGRA PARA EXCLUIR OU INATIVAR ENDERECO DO BENEFICIARIO
            string url = Url.Action("ListarEnderecos", "Administradora", new { id = administradoraId });
            return Json(new { success = true, url = url });
        }

 
    }
}