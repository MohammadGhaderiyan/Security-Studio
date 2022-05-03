using System.Windows;
using DevExpress.Xpf.Docking;

namespace SecurityStudio.Base.Control.Dock
{
    public class SsDocumentGroup : DocumentGroup
    {
        public SsDocumentGroup()
        {
            ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            Margin = new Thickness(0);
        }
    }
}