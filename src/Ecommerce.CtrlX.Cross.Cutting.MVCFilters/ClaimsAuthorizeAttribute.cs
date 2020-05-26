using Microsoft.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.Cross.Cutting.MVCFilters
{
    public class ClaimsAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly string _claimName;
        private readonly string _claimValue;

        public ClaimsAuthorizeAttribute(string claimName, string claimValue)
        {
            _claimName = claimName;
            _claimValue = claimValue;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var identity = (ClaimsIdentity)httpContext.User.Identity;

            var claim = identity.Claims.FirstOrDefault(c => c.Type == _claimName);

            return claim != null && claim.Value.Contains(_claimValue);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)
                filterContext.Result = new HttpStatusCodeResult((int)HttpStatusCode.Forbidden);
            else
                base.HandleUnauthorizedRequest(filterContext);
        }
    }
}
