using System.Windows;
using EO.Wpf;

namespace SecurityStudio.Base.Control.Web
{
    public class SsWebControl : WebControl
    {
        public SsWebControl()
        {
            WebView = new WebView();
        }


        public string Uri
        {
            get => (string)GetValue(UriProperty);
            set => SetValue(UriProperty, value);
        }

        public static readonly DependencyProperty UriProperty =
            DependencyProperty.Register("Uri", typeof(string), typeof(SsWebControl), new PropertyMetadata(null, UriPropertyChangedCallback));

        private static void UriPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var ssWebControl = (SsWebControl)d;
                ssWebControl.WebView.LoadUrl(e.NewValue.ToString());
            }
        }
    }
}