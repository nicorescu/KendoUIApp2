using System.Web;
using System.Web.Optimization;

namespace KendoUIApp2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/Kendo").Include("~/Kendo/kendo.all.min.js", "~/Kendo/js/kendo.aspnetmvc.min.js"));
            bundles.Add(new StyleBundle("~/Kendo/styles").Include("~/Kendo/kendo.common.min.css",
                "~/Kendo/kendo.default.min.css"));
        }
    }
}
