using System.Web.Optimization;

public class BundleConfig
{
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862 & https://zoompf.com/blog/2015/01/automatically-optimize-css-javascript-asp-net/
    public static void RegisterBundles(BundleCollection bundles)
    {

        bundles.UseCdn = true;
        BundleTable.EnableOptimizations = true;

        // ------------------------------------
        // -------------- CSS -----------------
        // ------------------------------------            

        // FULL STACK - Both Front and Back End
        bundles.Add(new StyleBundle("~/content/fullstack").Include(
            // Icons
            "~/Content/Font/icomoon/icomoon.css",
            // Bootstrap
            "~/Content/CSS/Bootstrap/4.1.2/bootstrap.min.css"
        ));

        // FRONT END - Forward Facing
        bundles.Add(new StyleBundle("~/content/frontend").Include(
        ));

        // BACK END - Content Management System
        bundles.Add(new StyleBundle("~/content/backend").Include(
            // Layout
            "~/Content/CSS/Admin/layout.css",
            // Components
            "~/Content/CSS/Admin/components.css",
            // Colors
            "~/Content/CSS/Admin/colors.css",
            // Admin
            "~/Content/CSS/Admin/admin.css"
        ));

        // GoogleFont CDN
        var GoogleFontCdnPath = "https://fonts.googleapis.com/css?family=Roboto+Condensed:300,400,700|Roboto:300,400,500,700,900";
        bundles.Add(new StyleBundle("~/content/GoogleFont", GoogleFontCdnPath));


        // ------------------------------------
        // --------------- JS -----------------
        // ------------------------------------

        // FULL STACK - Both Front and Back End
        bundles.Add(new ScriptBundle("~/bundles/fullstack").Include(
            // jQuery
            "~/Scripts/jQuery/3.3.1/jquery-3.3.1.min.js",
            // jQuery Migrate
            "~/Scripts/jQuery/jquery-migrate-3.0.0.min.js",
            // Bootstrap Popper - Required for Bootstrap 4.0
            "~/Scripts/Bootstrap/4.1.2/popper.min.js",
            // Bootstrap
            "~/Scripts/Bootstrap/4.1.2/bootstrap.min.js"
        ));

        // FRONT END - Forward Facing
        bundles.Add(new ScriptBundle("~/bundles/frontend").Include(
        ));

        // BACK END - Content Management System
        bundles.Add(new ScriptBundle("~/bundles/backend").Include(
            // jQuery Validation
            "~/Scripts/Validate/jquery.validate.js",
            "~/Scripts/Validate/jquery.validate.unobtrusive.js",
            // TinyMCE
            "~/Scripts/tinymce/tinymce.min.js",
            // pNotify
            "~/Scripts/pNotify/3.2.0/pnotify.min.js",
            // jQueryUI
            "~/Scripts/jQueryUI/1.11.4/jquery-ui.min.js",
            // Fab
            "~/Scripts/Fab/fab.min.js",
            // Datatable
            "~/Scripts/Datatables/Datatables.min.js",
            // Admin
            "~/Scripts/Admin/app.js",
            // Admin
            "~/Scripts/Admin/app.custom.js"       
        ));
    }
}