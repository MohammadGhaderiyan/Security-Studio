using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsLargeBarSplitButtonItem : BarSplitButtonItem
    {
        public SsLargeBarSplitButtonItem()
        {
            RibbonStyle = RibbonItemStyles.Large;
            Margin = new Thickness(0);
        }
    }
}