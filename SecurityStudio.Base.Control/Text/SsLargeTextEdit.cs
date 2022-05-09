using System.Windows;
using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.Text
{
    public class SsLargeTextEdit : SsTextEdit
    {
        public SsLargeTextEdit()
        {
            AcceptsReturn = true;
            Height = 50;
            VerticalContentAlignment = VerticalAlignment.Top;
            ControlWidthType = ControlWidthType.Auto;
        }
    }
}