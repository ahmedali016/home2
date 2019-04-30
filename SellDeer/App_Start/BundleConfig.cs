using System.Web;
using System.Web.Optimization;

namespace SellDeer
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(                        
                        "~/Scripts/jquery.js",
                        "~/Scripts/contact.js",
                        "~/Scripts/gmaps.js",
                        "~/Scripts/html5shiv.js",
                        "~/Scripts/jquery.prettyPhoto.js",
                        "~/Scripts/jquery.scrollUp.min.js",
                        "~/Scripts/main.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/price-range.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                      
                      "~/Content/animate.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/main.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/price-range.css",
                      "~/Content/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                "~/Content/Admincss/_all-skins.min.css",
                "~/Content/Admincss/AdminLTE.min.css",
                "~/Content/Admincss/bootstrap.min.css",
                "~/Content/Admincss/CustomAdminStyle.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Admin").Include(
                "~/Scripts/AdminScripts/app.min.js",
                "~/Scripts/AdminScripts/bootstrap.min.js",
                "~/Scripts/AdminScripts/fastclick.min.js",
                "~/Scripts/AdminScripts/jQuery-2.1.3.min.js",
                "~/Scripts/AdminScripts/jquery.slimscroll.min.js"));
        }
    }
}
