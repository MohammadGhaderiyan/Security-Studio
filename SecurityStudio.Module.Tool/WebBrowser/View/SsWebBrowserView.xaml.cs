using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.WebBrowser.ViewModel;

namespace SecurityStudio.Module.Tool.WebBrowser.View
{
    public partial class SsWebBrowserView : SsView
    {
        public SsWebBrowserView(SsWebBrowserViewModel ssWebBrowserViewModel)
            : base(ssWebBrowserViewModel)
        {
            InitializeComponent();
        }
    }
}