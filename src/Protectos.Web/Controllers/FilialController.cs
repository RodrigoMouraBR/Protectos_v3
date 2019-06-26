using Protectos.Application.Interfaces.Filiais;
using Protectos.Application.ViewModels.Filiais;
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
    public class FilialController : BaseController
    {
        private readonly string caminhoImagens = ConfigurationManager.AppSettings["Imagens"];

        private readonly IFilialApplicationService _filialApplicationService;

        public FilialController(IFilialApplicationService filialApplicationService)
        {
            _filialApplicationService = filialApplicationService;
        }
        public ActionResult Index()
        {
            return View(_filialApplicationService.FilialObterAtivo());
        }
        public ActionResult Detalhe(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var filialViewModel = _filialApplicationService.FilialObterPorId(id.Value);
            if (filialViewModel == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Detalhe", filialViewModel);
        }
        public ActionResult Incluir()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Incluir(FilialCadastroViewModel filialCadastroViewModel)
        {

            if (ModelState.IsValid)
            {
                var filial = _filialApplicationService.FilialCadastroAdicionar(filialCadastroViewModel);

                if (!filial.ValidationResult.IsValid)
                {
                    foreach (var erro in filial.ValidationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.ErrorMessage);
                    }
                    return View(filial);
                }
                if (filial.ValidationResult.ToString() != string.Empty)
                {
                    ViewBag.Sucesso = filial.ValidationResult.Errors.ToList();
                    return View(filial);
                }
                return RedirectToAction("Index");
            }
            return View(filialCadastroViewModel);
        }
        public ActionResult Editar(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var filialViewModel = _filialApplicationService.FilialObterPorId(id.Value);

            if (filialViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilialId = id;
            return View(filialViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(FilialViewModel filialViewModel)
        {
            if (ModelState.IsValid)
            {
                _filialApplicationService.FilialAtualizar(filialViewModel);
                return RedirectToAction("Index");
            }
            return View(filialViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var filialViewModel = _filialApplicationService.FilialObterPorId(id.Value);
            if (filialViewModel == null)
            {
                return HttpNotFound();
            }
            return View(filialViewModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _filialApplicationService.DeleteFilial(id);
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _filialApplicationService.Dispose();
            }
            base.Dispose(disposing);
        }

        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.FilialId = id;
            return PartialView("_EnderecosList", _filialApplicationService.FilialObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.FilialId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(FilialEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _filialApplicationService.FilialEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Filial", new { id = enderecoViewModel.FilialId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _filialApplicationService.FilialEnderecoObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(FilialEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _filialApplicationService.FilialEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Filial", new { id = enderecoViewModel.FilialId });
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

            var enderecoViewModel = _filialApplicationService.FilialEnderecoObterPorId(id.Value);
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
            var filialId = _filialApplicationService.FilialEnderecoObterPorId(id).FilialId;
            _filialApplicationService.DeleteFilialEndereco(id);
            string url = Url.Action("ListarEnderecos", "Filial", new { id = filialId });
            return Json(new { success = true, url = url });
        }


        //Email       
        public ActionResult ListarEmails(Guid id)
        {
            ViewBag.FilialId = id;
            return PartialView("_EmailsList", _filialApplicationService.FilialObterPorId(id).Emails);
        }
        public ActionResult AdicionarEmail(Guid id)
        {
            ViewBag.FilialId = id;
            return PartialView("_AdicionarEmail");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEmail(FilialEmailViewModel emailViewModel)
        {

            if (ModelState.IsValid)
            {
                _filialApplicationService.FilialEmailAdicionar(emailViewModel);
                string url = Url.Action("ListarEmails", "Filial", new { id = emailViewModel.FilialId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEmail", emailViewModel);
        }
        public ActionResult AtualizarEmail(Guid id)
        {
            return PartialView("_AtualizarEmail", _filialApplicationService.FilialEmailObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEmail(FilialEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _filialApplicationService.FilialEmailAtualizar(emailViewModel);

                string url = Url.Action("ListarEmails", "Filial", new { id = emailViewModel.FilialId });
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

            var emailViewModel = _filialApplicationService.FilialEmailObterPorId(id.Value);
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
            var filialId = _filialApplicationService.FilialEmailObterPorId(id).FilialId;
            _filialApplicationService.DeleteFilialEmail(id);
            string url = Url.Action("ListarEmails", "Filial", new { id = filialId });
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