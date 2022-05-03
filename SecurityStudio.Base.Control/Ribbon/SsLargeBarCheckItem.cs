using System.Windows;
using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsLargeBarCheckItem : BarCheckItem
    {
        public SsLargeBarCheckItem()
        {
            RibbonStyle = RibbonItemStyles.Large;
            Margin = new Thickness(0);
            GroupIndex = 0;
        }
    }
}