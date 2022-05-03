using System.Windows;
using DevExpress.Xpf.Ribbon;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsRibbonControl : RibbonControl
    {
        public SsRibbonControl()
        {
            RibbonStyle = RibbonStyle.Office2019;
            Margin = new Thickness(0);
        }
    }
}