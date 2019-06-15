using Protectos.Application.Interfaces.Clientes;
using Protectos.Application.ViewModels.Clientes;
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
    public class ClienteController : Controller
    {
        // GET: Cliente
        private readonly string caminhoImagens = ConfigurationManager.AppSettings["Imagens"];

        private readonly IClienteApplicationService _clienteApplicationService;

        public ClienteController(IClienteApplicationService clienteApplicationService)
        {
            _clienteApplicationService = clienteApplicationService;
        }
        public ActionResult Index()
        {
            return View(_clienteApplicationService.ClienteObterAtivo());
        }
        public ActionResult Detalhe(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _clienteApplicationService.ClienteObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Detalhe", clienteViewModel);
        }
        public ActionResult Incluir()
        {
            return View();
        }



        //TODO _clienteApplicationService.ClienteAdicionar(clienteCadastroViewModel);
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Incluir(ClienteCadastroViewModel clienteCadastroViewModel)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var cliente = _clienteApplicationService.ClienteAdicionar(clienteCadastroViewModel);

        //        if (!cliente.ValidationResult.IsValid)
        //        {
        //            foreach (var erro in cliente.ValidationResult.Errors)
        //            {
        //                ModelState.AddModelError(string.Empty, erro.ErrorMessage);
        //            }
        //            return View(cliente);
        //        }
        //        if (cliente.ValidationResult.ToString() != string.Empty)
        //        {
        //            ViewBag.Sucesso = cliente.ValidationResult.Errors.ToList();
        //            return View(cliente);
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    return View(clienteCadastroViewModel);
        //}

        public ActionResult Editar(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _clienteApplicationService.ClienteObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = id;
            return View(clienteViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.ClienteAtualizar(clienteViewModel);
                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _clienteApplicationService.ClienteObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clienteApplicationService.DeleteCliente(id);
            return RedirectToAction("Index");
        }

        //TODO IMPLEMENTAR Dispose CLIENTE
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _clienteApplicationService.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.ClienteId = id;
            return PartialView("_EnderecosList", _clienteApplicationService.ClienteObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.ClienteId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(ClienteEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.ClienteEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Cliente", new { id = enderecoViewModel.ClienteId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _clienteApplicationService.ClienteEnderecoObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(ClienteEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.ClienteEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Cliente", new { id = enderecoViewModel.ClienteId });
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

            var enderecoViewModel = _clienteApplicationService.ClienteEnderecoObterPorId(id.Value);
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
            var clienteId = _clienteApplicationService.ClienteEnderecoObterPorId(id).ClienteId;
            _clienteApplicationService.DeleteClienteEndereco(id);
            string url = Url.Action("ListarEnderecos", "Cliente", new { id = clienteId });
            return Json(new { success = true, url = url });
        }


        //Email       
        public ActionResult ListarEmails(Guid id)
        {
            ViewBag.ClienteId = id;
            return PartialView("_EmailsList", _clienteApplicationService.ClienteObterPorId(id).Emails);
        }
        public ActionResult AdicionarEmail(Guid id)
        {
            ViewBag.ClienteId = id;
            return PartialView("_AdicionarEmail");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEmail(ClienteEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.ClienteEmailAdicionar(emailViewModel);
                string url = Url.Action("ListarEmails", "Cliente", new { id = emailViewModel.ClienteId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEmail", emailViewModel);
        }
        public ActionResult AtualizarEmail(Guid id)
        {
            return PartialView("_AtualizarEmail", _clienteApplicationService.ClienteEmailObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEmail(ClienteEmailViewModel emailViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.ClienteEmailAtualizar(emailViewModel);

                string url = Url.Action("ListarEmails", "Cliente", new { id = emailViewModel.ClienteId });
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

            var emailViewModel = _clienteApplicationService.ClienteEmailObterPorId(id.Value);
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
            var clienteId = _clienteApplicationService.ClienteEmailObterPorId(id).ClienteId;
            _clienteApplicationService.DeleteClienteEmail(id);
            string url = Url.Action("ListarEmails", "Cliente", new { id = clienteId });
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
