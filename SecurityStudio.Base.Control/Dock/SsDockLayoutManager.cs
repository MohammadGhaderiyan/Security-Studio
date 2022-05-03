using System.Windows;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Docking.Base;

namespace SecurityStudio.Base.Control.Dock
{
    public class SsDockLayoutManager : DockLayoutManager
    {
        public SsDockLayoutManager()
        {
            FloatingMode = FloatingMode.Desktop;
            FloatingDocumentContainer = FloatingDocumentContainer.SingleDocument;
            RedrawContentWhenResizing = true;
            ShowContentWhenDragging = true;
            ViewStyle = DockingViewStyle.Light;
            Margin = new Thickness(0);
        }
    }
}