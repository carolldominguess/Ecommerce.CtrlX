﻿using System.Web;
using System.Web.Optimization;

namespace Ecommerce.CtrlX.UI.Site
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/Notificacao.min.js"));

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
                      "~/Content/site.css",
                      "~/Content/Notificacao.css"));
            
            bundles.Add(new StyleBundle("~/Content/indexcss").Include(
                      "~/Content/gallery.min.css",
                      "~/Content/gallery.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/products").Include(
                      "~/Scripts/jquery.mask.js",
                      "~/Scripts/Forms/products.js"));

            bundles.Add(new ScriptBundle("~/bundles/orders").Include(
                      "~/Scripts/jquery.mask.js",
                      "~/Scripts/Forms/orders.js"));
        }
    }
}

