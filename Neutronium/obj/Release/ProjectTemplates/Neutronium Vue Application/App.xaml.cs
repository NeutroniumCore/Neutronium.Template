﻿using Neutronium.Core.JavascriptFramework;
using Neutronium.WebBrowserEngine.ChromiumFx;
using Neutronium.JavascriptFramework.Vue;
using Neutronium.WPF;
using System.Linq;
using System;

namespace $safeprojectname$
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ChromiumFxWebBrowserApp
    {
        public ApplicationMode Mode { get; private set; }
        public bool RunTimeOnly => (Mode != ApplicationMode.Dev);
        public bool Debug => (Mode != ApplicationMode.Production);
        public Uri BuildUri(string relativepath) => (Mode == ApplicationMode.Dev) ?
                                new Uri("http://localhost:8080/index.html") : new Uri($"pack://application:,,,/View/{relativepath}/dist/index.html");

        public static App MainApplication => Current as App;

        protected override IJavascriptFrameworkManager GetJavascriptUIFrameworkManager()
        {
            return new VueSessionInjector();
        }

        protected override void OnStartUp(IHTMLEngineFactory factory)
        {
            Mode = GetApplicationMode(Args);
            factory.RegisterJavaScriptFrameworkAsDefault(new VueSessionInjectorV2 { RunTimeOnly = RunTimeOnly });
            base.OnStartUp(factory);
        }

        private static ApplicationMode GetApplicationMode(string[] args)
        {
#if DEBUG
            var normalizedArgs = args.Select(arg => arg.ToLower()).ToList();

            return (normalizedArgs.Contains("-dev")) ? ApplicationMode.Dev : (normalizedArgs.Contains("-prod"))? ApplicationMode.Production: ApplicationMode.Test;
#endif
            return ApplicationMode.Production;
        }
    }
}
