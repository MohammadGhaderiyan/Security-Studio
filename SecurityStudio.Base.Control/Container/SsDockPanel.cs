using System.Windows;
using System.Windows.Controls;

namespace SecurityStudio.Base.Control.Container
{
    public class SsDockPanel : DockPanel
    {
        public SsDockPanel()
        {
            LastChildFill = true;
            Margin = new Thickness(0);
        }
    }
}