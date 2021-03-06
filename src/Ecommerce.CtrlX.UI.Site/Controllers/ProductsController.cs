﻿using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Cross.Cutting.MVCFilters;
using Ecommerce.CtrlX.Infra.Data.UoW;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductsService _productsService;
        private readonly ICategoriesService _categoriesService;
        private readonly IUnitOfWork _uow;

        public ProductsController(IProductsService productsService, ICategoriesService categoriesService, IUnitOfWork uow)
        {
            _productsService = productsService;
            _categoriesService = categoriesService;
            _uow = uow;
        }

        //PermissoesProducts PV, PD, PI, PE, PX

        // GET: Products
        public ActionResult Index()
        {
            return View(_productsService.GetAll());
        }

        // GET: Products/Details/5
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PD")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var products = _productsService.GetProductsById(id.Value);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: Products/Create
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PI")]
        public ActionResult Create()
        {
            ViewBag.Categorias = _categoriesService.GetAll();
            var prod = new ProductsViewModel();
            return View(prod);
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PI")]
        public ActionResult Create(ProductsViewModel products)
        {
            var imageTypes = new string[]{
                    "image/gif",
                    "image/jpeg",
                    "image/pjpeg",
                    "image/png"
                };
            if (products.ImageUpload == null || products.ImageUpload.ContentLength == 0)
            {
                ModelState.AddModelError("ImageUpload", "Este campo é obrigatório");
            }
            else if (!imageTypes.Contains(products.ImageUpload.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Escolha uma imagem GIF, JPG ou PNG.");
            }

            if (ModelState.IsValid)
            {
                var cat = _categoriesService.GetCategoriesById(products.CategoriesId);
                products.CategoriesId = cat.CategoriesId;
                products.DataCadastro = DateTime.Now;
                products.Ativo = true;
                products.NameCategory = cat.DescriptionCategory;

                byte[] arrayImagem = null;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    products.ImageUpload.InputStream.CopyTo(memoryStream);
                    arrayImagem = memoryStream.ToArray();
                }

                products.Image = arrayImagem;

                //using (var binaryReader = new BinaryReader(products.ImageUpload.InputStream))
                //    products.Image = binaryReader.ReadBytes(products.ImageUpload.ContentLength);


                _productsService.Add(products);
                _uow.Commit();

                Success(string.Format("Produto incluído com sucesso!"), true);

                return RedirectToAction("Index");
            }

            return View(products);

        }

        // GET: Products/Edit/5
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PE")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.Categorias = _categoriesService.GetAll();
            var products = await _productsService.GetProdutosByIdAsync(id.Value);            
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PE")]
        public async Task<ActionResult> Edit(ProductsViewModel products)
        {
            var prod = await _productsService.GetProdutosByIdAsync(products.ProductsId);
            products.Image = prod.Image;
            if (ModelState.IsValid)
            {
                var cat = _categoriesService.GetCategoriesById(products.CategoriesId);
                products.CategoriesId = cat.CategoriesId;
                products.NameCategory = cat.DescriptionCategory;
                products.DataCadastro = DateTime.Now;
                products.Ativo = true;
                _productsService.Update(products);
                _uow.Commit();
                Success(string.Format("Produto alterado com sucesso!"), true);
                return RedirectToAction("Index");
            }            
            return View(products);
        }

        // GET: Products/Delete/5
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PX")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var products = _productsService.GetProductsById(id.Value);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ClaimsAuthorizeAttribute("PermissoesProducts", "PX")]
        public ActionResult DeleteConfirmed(int id)
        {
            _productsService.Remove(id);
            _uow.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _productsService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
