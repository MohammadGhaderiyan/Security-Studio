using System.Windows;
using System.Windows.Controls;

namespace SecurityStudio.Base.Control.Container
{
    public class SsContentControl : ContentControl
    {
        public SsContentControl()
        {
            HorizontalContentAlignment = HorizontalAlignment.Stretch;
            VerticalContentAlignment = VerticalAlignment.Stretch;
            Margin = new Thickness(0);
        }
    }
}