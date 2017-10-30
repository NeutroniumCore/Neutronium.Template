using Neutronium.Core.JavascriptFramework;
using Neutronium.WebBrowserEngine.ChromiumFx;
using Neutronium.JavascriptFramework.Knockout;

namespace $safeprojectname$
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ChromiumFxWebBrowserApp
    {
        protected override IJavascriptFrameworkManager GetJavascriptUIFrameworkManager()
        {
            return new KnockoutFrameworkManager();
        }
    }
}
