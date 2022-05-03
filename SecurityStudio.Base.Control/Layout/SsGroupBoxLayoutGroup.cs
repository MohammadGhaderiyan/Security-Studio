using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.LayoutControl;

namespace SecurityStudio.Base.Control.Layout
{
    public class SsGroupBoxLayoutGroup : LayoutGroup
    {
        public SsGroupBoxLayoutGroup()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            Orientation = Orientation.Vertical;
            Margin = new Thickness(0);
            View = LayoutGroupView.GroupBox;
        }
    }
}