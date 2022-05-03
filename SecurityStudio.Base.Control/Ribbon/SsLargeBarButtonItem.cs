using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsLargeBarButtonItem : BarButtonItem
    {
        public SsLargeBarButtonItem()
        {
            RibbonStyle = RibbonItemStyles.Large;
            Margin = new Thickness(0);
        }
    }
}