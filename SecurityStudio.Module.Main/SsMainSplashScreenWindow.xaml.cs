using System.Windows;
using System.Windows.Input;
using SecurityStudio.Base.Control.Window;

namespace SecurityStudio.Module.Main
{
    public partial class SsMainSplashScreenWindow : SsSplashScreenWindow
    {
        //private BackgroundWorker _backgroundWorker;

        public SsMainSplashScreenWindow()
        {
            InitializeComponent();
        }

        private void SsMainSplashScreenWindowOnLoaded(object sender, RoutedEventArgs e)
        {
            //_backgroundWorker = new BackgroundWorker();
            //_backgroundWorker.DoWork += (bSender, args) =>
            //{
            //};
            //_backgroundWorker.RunWorkerCompleted += (bSender, args) => Close();
            //_backgroundWorker.RunWorkerAsync();
        }

        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}