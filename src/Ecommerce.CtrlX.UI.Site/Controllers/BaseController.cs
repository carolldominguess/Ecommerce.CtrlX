using Ecommerce.CtrlX.CrossCutting.Tools;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Ecommerce.CtrlX.UI.Site.Controllers
{
    public class BaseController : Controller
    {
        public void Success(string message, bool dismissable = false) => AddAlert(Styles.Success, message, dismissable);

        public void Information(string message, bool dismissable = false) => AddAlert(Styles.Information, message, dismissable);

        public void Warning(string message, bool dismissable = false) => AddAlert(Styles.Warning, message, dismissable);

        public void Danger(string message, bool dismissable = false) => AddAlert(Styles.Danger, message, dismissable);

        private void AddAlert(string alertStyle, string message, bool dismissable)
        {
            var alerts = TempData.ContainsKey(Alert.TempDataKey)
                ? (List<Alert>)TempData[Alert.TempDataKey]
                : new List<Alert>();

            alerts.Add(new Alert
            {
                AlertStyle = alertStyle,
                Message = message,
                Dismissable = dismissable
            });

            TempData[Alert.TempDataKey] = alerts;
        }
    }
}