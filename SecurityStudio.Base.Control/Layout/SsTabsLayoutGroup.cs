using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.LayoutControl;

namespace SecurityStudio.Base.Control.Layout
{
    public class SsTabsLayoutGroup : LayoutGroup
    {
        public SsTabsLayoutGroup()
        {
            VerticalAlignment = VerticalAlignment.Stretch;
            HorizontalAlignment = HorizontalAlignment.Stretch;
            Orientation = Orientation.Vertical;
            View = LayoutGroupView.Tabs;
            Margin = new Thickness(0);
        }
    }
}