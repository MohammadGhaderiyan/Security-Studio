using System.Windows;
using DevExpress.Xpf.Core;

namespace SecurityStudio.Base.Control.Button
{
    public class SsSimpleButton : SimpleButton
    {
        public SsSimpleButton()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(0);
            MinWidth = 80;
            MinHeight = 25;
        }
    }
}