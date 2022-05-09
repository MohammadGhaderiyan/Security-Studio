using System.Windows;

namespace SecurityStudio.Base.Control.Text
{
    public class SsResultLargeTextEdit : SsLargeTextEdit
    {
        public SsResultLargeTextEdit()
        {
            IsReadOnly = true;
            Height = double.NaN;
            VerticalAlignment = VerticalAlignment.Stretch;
            HorizontalAlignment = HorizontalAlignment.Stretch;
        }
    }
}