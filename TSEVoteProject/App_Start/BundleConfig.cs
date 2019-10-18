using System.Web.Optimization;

namespace TSEVoteProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/JQuery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/JQuery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/signalr").Include(
                      "~/Scripts/jquery.signalR-2.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/indexjs").Include(
                      "~/Scripts/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/loginjs").Include(
                      "~/Scripts/login.js"));

            bundles.Add(new ScriptBundle("~/bundles/nowui").Include(
                      "~/Scripts/NowUI/plugins/perfect-scrollbar.jquery.min.js",
                      "~/Scripts/NowUI/plugins/chartjs.min.js",
                      "~/Scripts/NowUI/plugins/bootstrap-notify.js",
                      "~/Scripts/NowUI/core/jquery.min.js",
                      "~/Scripts/NowUI/core/popper.min.js",
                      "~/Scripts/NowUI/core/bootstrap.min.js",
                      "~/Scripts/NowUI/now-ui-dashboard.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/nowuicss").Include(
                      "~/Content/NowUI/now-ui-dashboard.css",
                      "~/Content/NowUI/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/logincss").Include(
                      "~/Content/Bootstrap/bootstrap.css",
                      "~/Content/CSS/Login.css"));

            bundles.Add(new StyleBundle("~/Content/indexcss").Include(
                      "~/Content/CSS/Index.css"));

            bundles.Add(new StyleBundle("~/Content/resultscss").Include(
                      "~/Content/Bootstrap/bootstrap.css",
                      "~/Content/CSS/Results.css"));
        }
    }
}
