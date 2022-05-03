using System.Windows;
using DevExpress.Xpf.LayoutControl;

namespace SecurityStudio.Base.Control.Layout
{
    public class SsLayoutItem : LayoutItem
    {
        public SsLayoutItem()
        {
            VerticalAlignment = VerticalAlignment.Center;
            HorizontalAlignment = HorizontalAlignment.Left;
            LabelHorizontalAlignment = HorizontalAlignment.Right;
            Margin = new Thickness(2);
        }
    }
}