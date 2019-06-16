using Protectos.Application.Interfaces.Corretoras;
using Protectos.Application.ViewModels.Corretoras;
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
    public class CorretoraController : BaseController
    {
        // GET: Corretora
        private readonly string caminhoImagens = ConfigurationManager.AppSettings["Imagens"];

        private readonly ICorretoraApplicationService _corretoraApplicationService;

        public CorretoraController(ICorretoraApplicationService corretoraApplicationService)
        {
            _corretoraApplicationService = corretoraApplicationService;
        }
        public ActionResult Index()
        {
            return View(_corretoraApplicationService.CorretoraObterAtivo());
        }
        public ActionResult Detalhe(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var corretoraViewModel = _corretoraApplicationService.CorretoraObterPorId(id.Value);
            if (corretoraViewModel == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Detalhe", corretoraViewModel);
        }
        public ActionResult Incluir()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Incluir(CorretoraCadastroViewModel corretoraCadastroViewModel)
        {

            if (ModelState.IsValid)
            {
                var corretora = _corretoraApplicationService.CorretoraCadastroAdicionar(corretoraCadastroViewModel);

                if (!corretora.ValidationResult.IsValid)
                {
                    foreach (var erro in corretora.ValidationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.ErrorMessage);
                    }
                    return View(corretora);
                }
                if (corretora.ValidationResult.ToString() != string.Empty)
                {
                    ViewBag.Sucesso = corretora.ValidationResult.Errors.ToList();
                    return View(corretora);
                }
                return RedirectToAction("Index");
            }
            return View(corretoraCadastroViewModel);
        }
        public ActionResult Editar(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var corretoraViewModel = _corretoraApplicationService.CorretoraObterPorId(id.Value);
            if (corretoraViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CorretoraId = id;
            return View(corretoraViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(CorretoraViewModel corretoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _corretoraApplicationService.CorretoraAtualizar(corretoraViewModel);
                return RedirectToAction("Index");
            }
            return View(corretoraViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var corretoraViewModel = _corretoraApplicationService.CorretoraObterPorId(id.Value);
            if (corretoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(corretoraViewModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _corretoraApplicationService.DeleteCorretora(id);
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _corretoraApplicationService.Dispose();
            }
            base.Dispose(disposing);
        }

        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.CorretoraId = id;
            return PartialView("_EnderecosList", _corretoraApplicationService.CorretoraObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.CorretoraId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(CorretoraEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _corretoraApplicationService.CorretoraEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Corretora", new { id = enderecoViewModel.CorretoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _corretoraApplicationService.CorretoraEnderecoObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(CorretoraEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _corretoraApplicationService.CorretoraEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Corretora", new { id = enderecoViewModel.CorretoraId });
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

            var enderecoViewModel = _corretoraApplicationService.CorretoraEnderecoObterPorId(id.Value);
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
            var corretoraId = _corretoraApplicationService.CorretoraEnderecoObterPorId(id).CorretoraId;
            _corretoraApplicationService.DeleteCorretoraEndereco(id);
            string url = Url.Action("ListarEnderecos", "Corretora", new { id = corretoraId });
            return Json(new { success = true, url = url });
        }


        //Email       
        public ActionResult ListarEmails(Guid id)
        {
            ViewBag.CorretoraId = id;
            return PartialView("_EmailsList", _corretoraApplicationService.CorretoraObterPorId(id).Emails);
        }
        public ActionResult AdicionarEmail(Guid id)
        {
            ViewBag.CorretoraId = id;
            return PartialView("_AdicionarEmail");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEmail(CorretoraEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _corretoraApplicationService.CorretoraEmailAdicionar(emailViewModel);
                string url = Url.Action("ListarEmails", "Corretora", new { id = emailViewModel.CorretoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEmail", emailViewModel);
        }
        public ActionResult AtualizarEmail(Guid id)
        {
            return PartialView("_AtualizarEmail", _corretoraApplicationService.CorretoraEmailObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEmail(CorretoraEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _corretoraApplicationService.CorretoraEmailAtualizar(emailViewModel);

                string url = Url.Action("ListarEmails", "Corretora", new { id = emailViewModel.CorretoraId });
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

            var emailViewModel = _corretoraApplicationService.CorretoraEmailObterPorId(id.Value);
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
            var corretoraId = _corretoraApplicationService.CorretoraEmailObterPorId(id).CorretoraId;
            _corretoraApplicationService.DeleteCorretoraEmail(id);
            string url = Url.Action("ListarEmails", "Corretora", new { id = corretoraId });
            return Json(new { success = true, url = url });
        }




        public ActionResult ObterImagemCliente(Guid id)
        {
            //var root = caminhoImagens;
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