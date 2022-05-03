using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsSmallBarSplitButtonItem : BarSplitButtonItem
    {
        public SsSmallBarSplitButtonItem()
        {
            RibbonStyle = RibbonItemStyles.SmallWithText;
            Margin = new Thickness(0);
        }
    }
}