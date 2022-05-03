using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Bar
{
    public class SsToolBarControl : ToolBarControl
    {
        public SsToolBarControl()
        {
            ShowDragWidget = false;
            AllowQuickCustomization = false;
            Margin = new Thickness(0);
        }
    }
}