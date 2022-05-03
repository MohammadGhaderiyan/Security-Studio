using System.Windows;
using System.Windows.Controls;

namespace SecurityStudio.Base.Control.Label
{
    public class SsTextBlock : TextBlock
    {
        public SsTextBlock()
        {
            VerticalAlignment = VerticalAlignment.Center;
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(0);
            TextWrapping = TextWrapping.Wrap;
        }
    }
}