using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Cross.Cutting.MVCFilters;
using Ecommerce.CtrlX.Infra.Data.UoW;
using System;
using System.Net;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    // PermissoesCategories = CV,CD,CI,CE,CX

    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _categoriesService;
        private readonly IUnitOfWork _uow;

        public CategoriesController(ICategoriesService categoriesService, IUnitOfWork uow)
        {
            _categoriesService = categoriesService;
            _uow = uow;
        }

        // GET: Categories
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CV")]
        public ActionResult Index()
        {
            return View(_categoriesService.GetAll());
        }

        // GET: Categories/Details/5
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CD")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cat = _categoriesService.GetCategoriesById(id.Value);
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View(cat);
        }

        // GET: Categories/Create
        [HttpGet]
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CI")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CI")]
        public ActionResult Create(CategoriesViewModel categories)
        {
            if (ModelState.IsValid)
            {
                categories.DataCadastro = DateTime.Now;
                categories.Ativo = true;
                _categoriesService.Add(categories);
                _uow.Commit();
                return RedirectToAction("Index");
            }

            return View(categories);
        }

        // GET: Categories/Edit/5
        [HttpGet]
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CE")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cat = _categoriesService.GetCategoriesById(id.Value);
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View(cat);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CE")]
        public ActionResult Edit(CategoriesViewModel categories)
        {
            if (ModelState.IsValid)
            {
                _categoriesService.Update(categories);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            return View(categories);
        }

        // GET: Categories/Delete/5
        [HttpGet]
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CX")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cat = _categoriesService.GetCategoriesById(id.Value);
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View(cat);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ClaimsAuthorizeAttribute("PermissoesCategories", "CX")]
        public ActionResult DeleteConfirmed(int id)
        {
            _categoriesService.Remove(id);
            _uow.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _categoriesService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
