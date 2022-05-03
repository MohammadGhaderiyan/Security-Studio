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
            SizeChanged += OnSizeChanged;
            ControlWidthType = ControlWidthType.Auto;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ControlWidthType == ControlWidthType.Auto)
                Width = e.NewSize.Width;
        }
    }
}