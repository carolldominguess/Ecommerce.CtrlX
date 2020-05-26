using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int? code)
        {
            return View("Error");
        }

        public ActionResult AccessDenied()
        {
            return View("_AccessDenied");
        }
    }
}