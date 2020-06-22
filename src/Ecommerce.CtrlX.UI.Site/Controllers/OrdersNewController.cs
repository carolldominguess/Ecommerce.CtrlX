using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Infra.Data.UoW;
using Ecommerce.CtrlX.UI.Site.Helpers;
using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    [Authorize]
    public class OrdersNewController : BaseController
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
            object result;
            if (PermissionHelper.ValidadePermission("PermissoesProducts", "PV"))
            {
                 result = _ordersNewService.ObterPedidos();
            }
            else
            {
                var user = User.Identity.GetUserName();
                 result = _ordersNewService.ObterPedidosByUser(user);
            }
            
            return View(result);
        }

        // GET: Orders/Details
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OD")]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ord = await _ordersNewService.GetOrdersByIdAsync(id.Value);
            var products = await _productsService.GetProdutosByIdAsync(ord.ProducstId);
            ord.Image = products.Image;

            if (ord == null)
            {
                return HttpNotFound();
            }
            return View(ord);
        }

        // GET: Orders/Create
        [HttpGet]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OI")]
        public async Task<ActionResult> Create(int id)
        {
            var products = await _productsService.GetProdutosByIdAsync(id);
            var orders = new OrdersNewViewModel
            {
                Date = DateTime.Now,
                ProducstId = id,
                Price = products.Price,
                Description = products.Description,
                Remarks = products.Remarks,
                Image = products.Image,
                User = User.Identity.GetUserName()
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
                Success(string.Format("Pedido efetuado com sucesso!"), true);
                return RedirectToAction("Index");
            }
            return View(orders);
        }

        // GET: Orders/Edit
        [HttpGet]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OE")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ord = _ordersNewService.GetOrderById(id.Value);
            var products = await _productsService.GetProdutosByIdAsync(ord.ProducstId);
            ord.Image = products.Image;
            ord.Date = DateTime.Now;
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
                orders.Date = DateTime.Now;
                _ordersNewService.Update(orders);
                _uow.Commit();
                Success(string.Format("Pedido alterado com sucesso!"), true);
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