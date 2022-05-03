using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsSmallBarButtonItem : BarButtonItem
    {
        public SsSmallBarButtonItem()
        {
            RibbonStyle = RibbonItemStyles.SmallWithText;
            Margin = new Thickness(0);
        }
    }
}