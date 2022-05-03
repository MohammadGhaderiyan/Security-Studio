using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.LayoutControl;

namespace SecurityStudio.Base.Control.Layout
{
    public class SsLayoutGroup : LayoutGroup
    {
        public SsLayoutGroup()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            Orientation = Orientation.Horizontal;
            View = LayoutGroupView.Group;
            Margin = new Thickness(0);
        }
    }
}