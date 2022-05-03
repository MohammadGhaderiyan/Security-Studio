using System.Windows;
using System.Windows.Controls;

namespace SecurityStudio.Base.Control.Container
{
    public class SsStackPanel : StackPanel
    {
        public SsStackPanel()
        {
            Orientation = Orientation.Horizontal;
            Margin = new Thickness(0);
        }
    }
}