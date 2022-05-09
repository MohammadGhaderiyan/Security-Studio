using System.Windows;

namespace SecurityStudio.Base.Control.Console
{
    public class SsWindowsConsoleControl : SsConsoleControl
    {
        public string FileName
        {
            get => (string)GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }

        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string),
                typeof(SsWindowsConsoleControl), new PropertyMetadata(null, FileNameChangedCallback));

        private static void FileNameChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var ssWindowsConsoleControl = (SsWindowsConsoleControl)d;
                ssWindowsConsoleControl.StartProcess(e.NewValue.ToString(), "");
            }
        }
    }
}