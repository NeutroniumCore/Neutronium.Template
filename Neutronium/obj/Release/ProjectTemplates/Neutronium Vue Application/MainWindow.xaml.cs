using $safeprojectname$.ViewModel;
using System.Windows;
using System;

namespace $safeprojectname$ 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public bool Debug => App.MainApplication.Debug;
        public Uri Uri => App.MainApplication.BuildUri("Main");

        public MainWindow() 
        {
            Initialized += MainWindow_Initialized;
            InitializeComponent();        
        }

        private void MainWindow_Initialized(object sender, EventArgs e) 
        {
            DataContext = new HelloViewModel();
        }

        protected override void OnClosed(EventArgs e) 
        {
            base.OnClosed(e);
            this.HtmlView.Dispose();
        }
    }
}
