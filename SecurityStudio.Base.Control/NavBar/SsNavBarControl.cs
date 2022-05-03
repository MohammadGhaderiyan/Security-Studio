using System.Windows;
using DevExpress.Xpf.NavBar;

namespace SecurityStudio.Base.Control.NavBar
{
    public class SsNavBarControl : NavBarControl
    {
        public SsNavBarControl()
        {
            View = new NavigationPaneView
            {
                MaxVisibleGroupCount = 10
            };
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;
            Margin = new Thickness();
        }
    }
}