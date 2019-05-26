using Protectos.Application.Interfaces.Entidades;
using Protectos.Application.ViewModels.Entidades;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
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
                _entidadeApplicationService.EntidadeAdicionar(entidadeViewModel);
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
                _entidadeApplicationService.EntidadeAdicionar(entidadeViewModel);
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
            var entidadeViewModel = _entidadeApplicationService.EntidadeObterPorId(id.Value);
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
            _entidadeApplicationService.DeleteEntidade(id);
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
        //Endereco       
        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_EnderecosList", _entidadeApplicationService.EntidadeObterPorId(id).Enderecos);
        }
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.AdministradoraId = id;
            return PartialView("_AdicionarEndereco");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(EntidadeEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _entidadeApplicationService.EntidadeEnderecoAdicionar(enderecoViewModel);
                string url = Url.Action("ListarEnderecos", "Entidade", new { id = enderecoViewModel.EntidadeId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", enderecoViewModel);
        }
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _entidadeApplicationService.EntidadeEnderecoObterPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(EntidadeEnderecoViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _entidadeApplicationService.EntidadeEnderecoAtualizar(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Entidade", new { id = enderecoViewModel.EntidadeId });
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

            var enderecoViewModel = _entidadeApplicationService.EntidadeEnderecoObterPorId(id.Value);
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
            var entidadeId = _entidadeApplicationService.EntidadeEnderecoObterPorId(id).EntidadeId;
            _entidadeApplicationService.DeleteEntidadeEndereco(id);
            string url = Url.Action("ListarEnderecos", "Administradora", new { id = entidadeId });
            return Json(new { success = true, url = url });
        }
        public ActionResult ObterImagemCliente(Guid id)
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
