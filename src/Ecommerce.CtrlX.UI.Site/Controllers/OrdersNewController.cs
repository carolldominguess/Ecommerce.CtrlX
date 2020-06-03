using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Infra.Data.UoW;
using System;
using System.Net;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class OrdersNewController : Controller
    {
        private readonly IOrdersNewService _ordersNewService;
        private readonly IUnitOfWork _uow;
        private readonly IProductsService _productsService;

        public OrdersNewController(IOrdersNewService ordersNewService, IUnitOfWork uow, IProductsService productsService)
        {
            _ordersNewService = ordersNewService;
            _uow = uow;
            _productsService = productsService;
        }


        // GET: Orders
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OV")]
        public ActionResult Index()
        {
            return View(_ordersNewService.ObterPedidos());
        }

        // GET: Orders/Details
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OD")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ord = _ordersNewService.GetOrderById(id.Value);
            if (ord == null)
            {
                return HttpNotFound();
            }
            return View(ord);
        }

        // GET: Orders/Create
        [HttpGet]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OI")]
        public ActionResult Create(int id)
        {
            var products = _productsService.GetProductsById(id);
            var orders = new OrdersNewViewModel
            {
                ProducstId = products.ProductsId,
                Price = products.Price,
                Description = products.Description,
                Remarks = products.Remarks
            };

            return View(orders);
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OI")]
        public ActionResult Create(OrdersNewViewModel orders)
        {
            if (ModelState.IsValid)
            {
                orders.Date = DateTime.Now;
                _ordersNewService.Add(orders);
                _uow.Commit();
                return RedirectToAction("Index");
            }

            return View(orders);
        }

        // GET: Orders/Edit
        [HttpGet]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OE")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ord = _ordersNewService.GetOrderById(id.Value);
            if (ord == null)
            {
                return HttpNotFound();
            }
            return View(ord);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OE")]
        public ActionResult Edit(OrdersNewViewModel orders)
        {
            if (ModelState.IsValid)
            {
                _ordersNewService.Update(orders);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            return View(orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _ordersNewService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}