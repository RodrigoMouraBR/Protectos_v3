using Protectos.Application.Interfaces.Administradoras;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Domain.Generics.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
{

    public class AdministradoraController : BaseController
    {
        private readonly string caminhoImagens = ConfigurationManager.AppSettings["Imagens"];

        private readonly IAdministradoraApplicationService _administradoraApplicationService;

        public AdministradoraController(IAdministradoraApplicationService administradoraApplicationService)
        {
            _administradoraApplicationService = administradoraApplicationService;
        }
        public ActionResult Index()
        {
            return View(_administradoraApplicationService.AdministradoraObterAtivo());
        }
        public ActionResult Detalhe(Guid? id)
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

            return PartialView("_Detalhe", administradoraViewModel);
        }
        public ActionResult Incluir()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Incluir(AdministradoraCadastroViewModel administradoraCadastroViewModel)
        {

            if (ModelState.IsValid)
            {
                var administradora = _administradoraApplicationService.AdministradoraCadastroAdicionar(administradoraCadastroViewModel);

                if (!administradora.ValidationResult.IsValid)
                {
                    foreach (var erro in administradora.ValidationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.ErrorMessage);
                    }
                    return View(administradora);
                }
                if (administradora.ValidationResult.ToString() != string.Empty)
                {
                    ViewBag.Sucesso = administradora.ValidationResult.Errors.ToList();
                    return View(administradora);
                }
                return RedirectToAction("Index");
            }
            return View(administradoraCadastroViewModel);
        }
        public ActionResult Editar(Guid? id)
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
            ViewBag.AdministradoraId = id;
            return View(administradoraViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(AdministradoraViewModel administradoraViewModel)
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
            _administradoraApplicationService.DeleteAdministradora(id);
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

        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_EnderecosList", _administradoraApplicationService.AdministradoraObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(AdministradoraEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _administradoraApplicationService.AdministradoraEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Administradora", new { id = enderecoViewModel.AdministradoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _administradoraApplicationService.AdministradoraEnderecoObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(AdministradoraEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _administradoraApplicationService.AdministradoraEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Administradora", new { id = enderecoViewModel.AdministradoraId });
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

            var enderecoViewModel = _administradoraApplicationService.AdministradoraEnderecoObterPorId(id.Value);
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
            var administradoraId = _administradoraApplicationService.AdministradoraEnderecoObterPorId(id).AdministradoraId;
            _administradoraApplicationService.DeleteAdministradoraEndereco(id);
            string url = Url.Action("ListarEnderecos", "Administradora", new { id = administradoraId });
            return Json(new { success = true, url = url });
        }


        //Email       
        public ActionResult ListarEmails(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_EmailsList", _administradoraApplicationService.AdministradoraObterPorId(id).Emails);
        }
        public ActionResult AdicionarEmail(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_AdicionarEmail");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEmail(AdministradoraEmailViewModel emailViewModel)
        {
            
            if (ModelState.IsValid)
            {
                _administradoraApplicationService.AdministradoraEmailAdicionar(emailViewModel);
                string url = Url.Action("ListarEmails", "Administradora", new { id = emailViewModel.AdministradoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEmail", emailViewModel);
        }
        public ActionResult AtualizarEmail(Guid id)
        {
            return PartialView("_AtualizarEmail", _administradoraApplicationService.AdministradoraEmailObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEmail(AdministradoraEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _administradoraApplicationService.AdministradoraEmailAtualizar(emailViewModel);

                string url = Url.Action("ListarEmails", "Administradora", new { id = emailViewModel.AdministradoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarEmail", emailViewModel);
        }
        public ActionResult DeletarEmail(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var emailViewModel = _administradoraApplicationService.AdministradoraEmailObterPorId(id.Value);
            if (emailViewModel == null)
            {
                return HttpNotFound();
            }
            return PartialView("_DeletarEmail", emailViewModel);
        }
        [HttpPost, ActionName("DeletarEmail")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarEmailConfirmed(Guid id)
        {
            var administradoraId = _administradoraApplicationService.AdministradoraEmailObterPorId(id).AdministradoraId;
            _administradoraApplicationService.DeleteAdministradoraEmail(id);
            string url = Url.Action("ListarEmails", "Administradora", new { id = administradoraId });
            return Json(new { success = true, url = url });
        }




        public ActionResult ObterImagemCliente(Guid id)
        {

            var foto = Directory.GetFiles(caminhoImagens, id + "*").FirstOrDefault();
            if (foto != null && !foto.StartsWith(caminhoImagens))
            {
                // Validando qualquer acesso indevido além da pasta permitida
                throw new HttpException(403, "Acesso Negado");
            }
            if (foto == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return File(foto, "image/jpeg");
        }
    }
}