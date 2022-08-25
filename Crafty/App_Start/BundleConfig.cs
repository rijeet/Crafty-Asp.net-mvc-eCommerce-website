﻿using System.Web;
using System.Web.Optimization;

namespace Crafty
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


            //for admin
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-ui.min.js",
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/metismenu.min.js",
                "~/Scripts/waves.js",
                "~/Scripts/feather.min.js",
                "~/Scripts/jquery.slimscroll.min.js",
                "~/plugins/apexcharts/apexcharts.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/jquery-ui.min.css",
                "~/Content/icons.min.css",
                "~/Content/metisMenu.min.css",
                "~/Content/app.min.css"));
        }
    }
}
