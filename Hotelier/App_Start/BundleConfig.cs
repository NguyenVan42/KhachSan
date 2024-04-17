using System.Web;
using System.Web.Optimization;

namespace Hotelier
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

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/lib/animate/animate.min.css",
                      "~/Content/lib/owlcarousel/assets/owl.carousel.min.css",
                      "~/Content/lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/style.css",
                      "~/Content/css/site.css"));

            bundles.Add(new StyleBundle("~/Content/jsLibraries").Include(
                      "~/Content/lib/wow/wow.min.js",
                      "~/Content/lib/easing/easing.min.js",
                      "~/Content/lib/waypoints/waypoints.min.js",
                      "~/Content/lib/counterup/counterup.min.js",
                      "~/Content/lib/owlcarousel/owl.carousel.min.js",
                      "~/Content/lib/tempusdominus/js/moment.min.js",
                      "~/Content/lib/tempusdominus/js/moment-timezone.min.js",
                      "~/Content/lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js"
                      ));

        }
    }
}
