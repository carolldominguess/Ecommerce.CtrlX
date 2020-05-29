using System.Web;
using System.Web.Optimization;

namespace Ecommerce.CtrlX.UI.Site
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/TemmplateCss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/template/font-awesome.css",
                      "~/Content/template/owl.carousel.css",
                      "~/Content/template/responsive.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/TemmplateJs").Include(
                      "~/Scripts/template/bxslider.js",
                      "~/Scripts/template/jquery.easing.1.3.js",
                      "~/Scripts/template/jquery.sticky.js",
                      "~/Scripts/template/owl.carousel.js",
                      "~/Scripts/template/script.slider.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/products").Include(
                      "~/Scripts/jquery.mask.js",
                      "~/Scripts/Forms/products.js"));
        }
    }
}

