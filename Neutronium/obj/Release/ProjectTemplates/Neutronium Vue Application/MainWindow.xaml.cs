using Neutronium_Simple_Application.ViewModel;
using System.Windows;
using System;
using Neutronium.BuildingBlocks.SetUp;

namespace Neutronium_Simple_Application {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public SetUpViewModel SetUp => App.SetUp;

        public MainWindow() {
            Initialized += MainWindow_Initialized;
            InitializeComponent();
        }

        private void MainWindow_Initialized(object sender, EventArgs e) {
            DataContext = new HelloViewModel();
        }

        protected override void OnClosed(EventArgs e) {
            base.OnClosed(e);
            this.WcBrowser.Dispose();
        }
    }
}
