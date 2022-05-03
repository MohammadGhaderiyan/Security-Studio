using System.Windows;
using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Image
{
    public class SsImageEdit : ImageEdit
    {
        public SsImageEdit()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            ShowBorder = false;
            ShowMenu = false;
            ShowLoadDialogOnClickMode = ShowLoadDialogOnClickMode.Never;
            Width = 150;
            Height = 200;
            Margin = new Thickness(0);
        }
    }
}