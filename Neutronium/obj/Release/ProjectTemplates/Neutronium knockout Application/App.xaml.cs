using Neutronium.Core.JavascriptFramework;
using Neutronium.WebBrowserEngine.ChromiumFx;
using Neutronium.JavascriptFramework.Knockout;

namespace Neutronium_knockout_Application1
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
