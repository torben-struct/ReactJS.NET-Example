using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApplication1.ReactConfig), "Configure")]
namespace WebApplication1
{
    public static class ReactConfig
    {
        public static void Configure()
        {
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();

            ReactSiteConfiguration.Configuration
                .AddScript("~/Scripts/src/Components/Comment.jsx")
                .AddScript("~/Scripts/src/Components/CommentList.jsx")
                .AddScript("~/Scripts/src/Components/CommentForm.jsx")
                .AddScript("~/Scripts/src/Components/CommentBox.jsx");
        }
    }
}