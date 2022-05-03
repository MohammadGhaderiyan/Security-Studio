using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsSmallBarCheckItem : BarCheckItem
    {
        public SsSmallBarCheckItem()
        {
            RibbonStyle = RibbonItemStyles.SmallWithText;
            Margin = new Thickness(0);
        }
    }
}