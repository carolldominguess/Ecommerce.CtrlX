using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Cross.Cutting.MVCFilters;
using Ecommerce.CtrlX.Infra.Data.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;
        private readonly IUnitOfWork _uow;

        public OrdersController(IOrdersService ordersService, IUnitOfWork uow)
        {
            _ordersService = ordersService;
            _uow = uow;
        }

        // GET: Orders
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OV")]
        public ActionResult Index(int id)
        {
            return View(_ordersService.GetOrderById(id));
        }

        // GET: Orders/Details
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OD")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ord = _ordersService.GetOrderById(id.Value);
            if (ord == null)
            {
                return HttpNotFound();
            }
            return View(ord);
        }

        // GET: Orders/Create
        [HttpGet]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OI")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ClaimsAuthorizeAttribute("PermissoesOrders", "OI")]
        public ActionResult Create(OrdersViewModel orders)
        {
            if (ModelState.IsValid)
            {
                orders.Date = DateTime.Now;
                _ordersService.Add(orders);
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
            var ord = _ordersService.GetOrderById(id.Value);
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
        public ActionResult Edit(OrdersViewModel orders)
        {
            if (ModelState.IsValid)
            {
                _ordersService.Update(orders);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            return View(orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _ordersService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}