using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.GoogleDork.ViewModel;

namespace SecurityStudio.Module.Tool.GoogleDork.View
{
    public partial class SsGoogleDorkView : SsView
    {
        public SsGoogleDorkView(SsGoogleDorkViewModel ssGoogleDorkViewModel)
            : base(ssGoogleDorkViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            ((SsGoogleDorkViewModel)SsViewModel).WebBrowser = WebBrowserMain;
        }
    }
}