using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Infra.Data.UoW;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class ProductsController : Controller
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

        // GET: Products
        public ActionResult Index()
        {
            return View(_productsService.GetAll());
        }

        // GET: Products/Details/5
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
        public ActionResult Create()
        {
            ViewBag.Categorias = _categoriesService.GetAll();
            var prod = new ProductsViewModel();
            return View(prod);
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductsViewModel products)
        {
            //var imageTypes = new string[]{
            //        "image/gif",
            //        "image/jpeg",
            //        "image/pjpeg",
            //        "image/png"
            //    };
            //if (products.ImageUpload == null || products.ImageUpload.ContentLength == 0)
            //{
            //    ModelState.AddModelError("ImageUpload", "Este campo é obrigatório");
            //}
            //else if (!imageTypes.Contains(products.ImageUpload.ContentType))
            //{
            //    ModelState.AddModelError("ImageUpload", "Escolha uma imagem GIF, JPG ou PNG.");
            //}


            if (ModelState.IsValid)
            {
                var cat = _categoriesService.GetCategoriesById(products.CategoriesId);
                products.CategoriesId = cat.CategoriesId;
                products.DataCadastro = DateTime.Now;
                products.Ativo = true;


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
                return RedirectToAction("Index");
            }

            return View(products);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductsViewModel products)
        {
            if (ModelState.IsValid)
            {
                _productsService.Update(products);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        // GET: Products/Delete/5
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
