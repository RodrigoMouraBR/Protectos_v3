using Protectos.Application.Interfaces.Operadoras;
using Protectos.Application.ViewModels.Operadoras;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Protectos.Web.Controllers
{

    public class OperadoraController : Controller
    {
        private readonly IOperadoraApplicationService _operadoraApplicationService;
        public OperadoraController(IOperadoraApplicationService operadoraApplicationService)
        {
            _operadoraApplicationService = operadoraApplicationService;
        }
        public ActionResult Index()
        {
            return View(_operadoraApplicationService.OperadoraObterTodos());
        }
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var OperadoraViewModel = _operadoraApplicationService.OperadoraObterPorId(id.Value);
            if (OperadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(OperadoraViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OperadoraViewModel OperadoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraAdicionar(OperadoraViewModel);
                return RedirectToAction("Index");
            }
            return View(OperadoraViewModel);
        }
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperadoraViewModel OperadoraViewModel = _operadoraApplicationService.OperadoraObterPorId(id.Value);
            if (OperadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(OperadoraViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OperadoraViewModel OperadoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _operadoraApplicationService.OperadoraAdicionar(OperadoraViewModel);
                return RedirectToAction("Index");
            }
            return View(OperadoraViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var OperadoraViewModel = _operadoraApplicationService.OperadoraObterPorId(id.Value);
            if (OperadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(OperadoraViewModel);
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
            ViewBag.AdministradoraId = id;
            return PartialView("_EnderecosList", _operadoraApplicationService.OperadoraObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.AdministradoraId = id;
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
        public ActionResult AtualizarEndereco(Guid id)
        {
            //TODO : FALTA OBTER ENDERECO POR ID DA OPERADORA
            //   return PartialView("_AtualizarEndereco", _operadoraApplicationService.OperadoraEnderecoObterTodos(id));
            return PartialView("_AtualizarEndereco", null);
        }
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
        //    var administradoraId = _OperadoraApplicationService.OperadoraEnderecoObterPorId(id).AdministradoraId;
        //    _OperadoraApplicationService.DeleteOperadoraEndereco(id);
        //    string url = Url.Action("ListarEnderecos", "Administradora", new { id = administradoraId });
        //    return Json(new { success = true, url = url });
        //}

        public ActionResult ObterImagemOperadora(Guid id)
        {
            var root = @"C:\Users\rodri\Pictures\Spartacus\";
            var foto = Directory.GetFiles(root, id + "*").FirstOrDefault();
            if (foto != null && !foto.StartsWith(root))
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