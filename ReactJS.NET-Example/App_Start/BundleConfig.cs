using System.Web.Optimization;
using System.Web.Optimization.React;

namespace WebApplication1
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                "~/Scripts/src/Components/Comment.jsx",
                "~/Scripts/src/Components/CommentList.jsx",
                "~/Scripts/src/Components/CommentForm.jsx",
                "~/Scripts/src/Components/CommentBox.jsx",
                "~/Scripts/src/main.jsx"
            ));

            // Forces files to be combined and minified in debug mode
            // Only used here to demonstrate how combination/minification works
            // Normally you would use unminified versions in debug mode.
            BundleTable.EnableOptimizations = true;
        }
    }
}
