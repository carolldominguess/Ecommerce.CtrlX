using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Infra.Data.UoW;
using System;
using System.Net;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class DepartamentsController : Controller
    {
        private readonly IDepartamentsService _departamentsService;
        private readonly IUnitOfWork _uow;

        public DepartamentsController(IDepartamentsService departamentsService, IUnitOfWork uow)
        {
            _departamentsService = departamentsService;
            _uow = uow;
        }


        // GET: Departaments
        public ActionResult Index()
        {
            return View(_departamentsService.GetAll());
        }

        // GET: Departaments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dep = _departamentsService.GetDepartamentsById(id.Value);
            if (dep == null)
            {
                return HttpNotFound();
            }
            return View(dep);
        }

        // GET: Departaments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departaments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartamentsViewModel departaments)
        {
            if (ModelState.IsValid)
            {
                departaments.DataCadastro = DateTime.Now;
                departaments.Ativo = true;
                _departamentsService.Add(departaments);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            return View(departaments);
        }

        // GET: Departaments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dep = _departamentsService.GetDepartamentsById(id.Value);
            if (dep == null)
            {
                return HttpNotFound();
            }
            return View(dep);
        }

        // POST: Departaments/Edit/5        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartamentsViewModel departaments)
        {
            if (ModelState.IsValid)
            {
                departaments.DataAlteracao = DateTime.Now;
                _departamentsService.Update(departaments);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            return View(departaments);
        }

        // GET: Departaments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var departaments = _departamentsService.GetDepartamentsById(id.Value);
            if (departaments == null)
            {
                return HttpNotFound();
            }
            return View(departaments);
        }

        // POST: Departaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _departamentsService.Remove(id);
            _uow.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _departamentsService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
