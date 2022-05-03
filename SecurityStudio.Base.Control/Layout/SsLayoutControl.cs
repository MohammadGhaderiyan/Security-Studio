using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.LayoutControl;

namespace SecurityStudio.Base.Control.Layout
{
    public class SsLayoutControl : LayoutControl
    {
        public SsLayoutControl()
        {
            VerticalAlignment = VerticalAlignment.Stretch;
            HorizontalAlignment = HorizontalAlignment.Stretch;
            Orientation = Orientation.Vertical;
            Padding = new Thickness(0);
            Margin = new Thickness(0);
        }
    }
}