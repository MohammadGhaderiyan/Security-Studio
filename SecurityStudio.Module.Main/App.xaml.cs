using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using DevExpress.Xpf.Core;
using Ninject;
using SecurityStudio.Module.Main.Main.View;
using SecurityStudio.Service.Main.Session;

namespace SecurityStudio.Module.Main
{
    public partial class App : Application
    {
        private readonly Shell _shell;

        public App()
        {
            try
            {
                _shell = new Shell();
                DispatcherUnhandledException += OnDispatcherUnhandledException;
                SetCulture();
                SetTheme();
            }
            catch (Exception? exception)
            {
                while (exception != null)
                {
                    MessageBox.Show(exception.Message);
                    exception = exception.InnerException;
                }
            }
        }

        private void SetCulture()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        private void SetTheme()
        {
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013LightGrayName;
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            DXMessageBox.Show(e.Exception.Message, "Security Studio Error !!!",
                MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                //var ssMainSplashScreenWindow = new SsMainSplashScreenWindow();
                //ssMainSplashScreenWindow.Show();

                var kernel = _shell.Kernel;

                var sessionService = kernel.Get<ISessionService>();
                sessionService.SetKernel(kernel);

                var ssMainWindowView = kernel.Get<SsMainWindowView>();
                ssMainWindowView.Loaded += (_, _) =>
                {
                };
                MainWindow = ssMainWindowView;

                if (MainWindow != null)
                    MainWindow.ShowDialog();

                Shutdown();
            }
            catch (Exception? exception)
            {
                while (exception != null)
                {
                    MessageBox.Show(exception.Message);
                    exception = exception.InnerException;
                }
            }
        }
    }
}