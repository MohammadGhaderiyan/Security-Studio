using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.ApiPlatform.ViewModel;

namespace SecurityStudio.Module.Tool.ApiPlatform.View
{
    public partial class SsApiPlatformView : SsView
    {
        public SsApiPlatformView(SsApiPlatformViewModel ssApiPlatformViewModel)
            : base(ssApiPlatformViewModel)
        {
            InitializeComponent();
        }
    }
}