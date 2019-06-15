using Protectos.Application.Interfaces.Operadoras;
using Protectos.Application.ViewModels.Operadoras;
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

    public class OperadoraController : Controller
    {
        private readonly string caminhoImagens = ConfigurationManager.AppSettings["Imagens"];

        private readonly IOperadoraApplicationService _operadoraApplicationService;

        public OperadoraController(IOperadoraApplicationService operadoraApplicationService)
        {
            _operadoraApplicationService = operadoraApplicationService;
        }
        public ActionResult Index()
        {
            return View(_operadoraApplicationService.OperadoraObterAtivo());
        }
        public ActionResult Detalhe(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var operadoraViewModel = _operadoraApplicationService.OperadoraObterPorId(id.Value);
            if (operadoraViewModel == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Detalhe", operadoraViewModel);
        }
        public ActionResult Incluir()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Incluir(OperadoraViewModel operadoraViewModel)
        {

            if (ModelState.IsValid)
            {
                var operadora = _operadoraApplicationService.OperadoraAdicionar(operadoraViewModel);

                if (!operadora.ValidationResult.IsValid)
                {
                    foreach (var erro in operadora.ValidationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.ErrorMessage);
                    }
                    return View(operadora);
                }
                if (operadora.ValidationResult.ToString() != string.Empty)
                {
                    ViewBag.Sucesso = operadora.ValidationResult.Errors.ToList();
                    return View(operadora);
                }
                return RedirectToAction("Index");
            }
            return View(operadoraViewModel);
        }
        public ActionResult Editar(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var operadoraViewModel = _operadoraApplicationService.OperadoraObterPorId(id.Value);
            if (operadoraViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.OperadoraId = id;
            return View(operadoraViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(OperadoraViewModel operadoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraAtualizar(operadoraViewModel);
                return RedirectToAction("Index");
            }
            return View(operadoraViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var operadoraViewModel = _operadoraApplicationService.OperadoraObterPorId(id.Value);
            if (operadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(operadoraViewModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _operadoraApplicationService.DeleteOperadora(id);
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _operadoraApplicationService.Dispose();
            }
            base.Dispose(disposing);
        }

        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.OperadoraId = id;
            return PartialView("_EnderecosList", _operadoraApplicationService.OperadoraObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.OperadoraId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(OperadoraEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Operadora", new { id = enderecoViewModel.OperadoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        //TODO IMPLEMENTAR _operadoraApplicationService.OperadoraEnderecoObterPorId
        //public ActionResult AtualizarEndereco(Guid id)
        //{
        //    return PartialView("_AtualizarEndereco", _operadoraApplicationService.OperadoraEnderecoObterPorId(id));
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(OperadoraEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Operadora", new { id = enderecoViewModel.OperadoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarEndereco", enderecoViewModel);
        }
        ////TODO IMPLEMENTAR _operadoraApplicationService.OperadoraEnderecoObterPorId
        //public ActionResult DeletarEndereco(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    var enderecoViewModel = _operadoraApplicationService.OperadoraEnderecoObterPorId(id.Value);
        //    if (enderecoViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return PartialView("_DeletarEndereco", enderecoViewModel);
        //}
        //[HttpPost, ActionName("DeletarEndereco")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeletarEnderecoConfirmed(Guid id)
        //{
        //    var operadoraId = _operadoraApplicationService.OperadoraEnderecoObterPorId(id).OperadoraId;
        //    _operadoraApplicationService.DeleteOperadoraEndereco(id);
        //    string url = Url.Action("ListarEnderecos", "Operadora", new { id = operadoraId });
        //    return Json(new { success = true, url = url });
        //}


        //Email       
        public ActionResult ListarEmails(Guid id)
        {
            ViewBag.OperadoraId = id;
            return PartialView("_EmailsList", _operadoraApplicationService.OperadoraObterPorId(id).Emails);
        }
        public ActionResult AdicionarEmail(Guid id)
        {
            ViewBag.OperadoraId = id;
            return PartialView("_AdicionarEmail");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEmail(OperadoraEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraEmailAdicionar(emailViewModel);
                string url = Url.Action("ListarEmails", "Operadora", new { id = emailViewModel.OperadoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEmail", emailViewModel);
        }        
        //public ActionResult AtualizarEmail(Guid id)
        //{
        //    return PartialView("_AtualizarEmail", _operadoraApplicationService.OperadoraEmailObterPorId(id));
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEmail(OperadoraEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraEmailAtualizar(emailViewModel);

                string url = Url.Action("ListarEmails", "Operadora", new { id = emailViewModel.OperadoraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarEmail", emailViewModel);
        }
        //TODO IMPLEMENTAR _operadoraApplicationService.OperadoraEnderecoObterPorId
        //public ActionResult DeletarEmail(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    var emailViewModel = _operadoraApplicationService.OperadoraEmailObterPorId(id.Value);
        //    if (emailViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return PartialView("_DeletarEmail", emailViewModel);
        //}
        //[HttpPost, ActionName("DeletarEmail")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeletarEmailConfirmed(Guid id)
        //{
        //    var operadoraId = _operadoraApplicationService.OperadoraEmailObterPorId(id).OperadoraId;
        //    _operadoraApplicationService.DeleteOperadoraEmail(id);
        //    string url = Url.Action("ListarEmails", "Operadora", new { id = operadoraId });
        //    return Json(new { success = true, url = url });
        //}




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