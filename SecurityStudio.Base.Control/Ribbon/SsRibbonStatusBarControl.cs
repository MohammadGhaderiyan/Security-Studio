using System.Windows;
using DevExpress.Xpf.Ribbon;

namespace SecurityStudio.Base.Control.Ribbon
{
    public class SsRibbonStatusBarControl : RibbonStatusBarControl
    {
        public SsRibbonStatusBarControl()
        {
            IsSizeGripVisible = true;
            Margin = new Thickness(0);
        }
    }
}