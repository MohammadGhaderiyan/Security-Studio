using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.WebServer.ViewModel;

namespace SecurityStudio.Module.Tool.WebServer.View
{
    public partial class SsWebServerView : SsView
    {
        public SsWebServerView(SsWebServerViewModel ssWebServerViewModel)
            : base(ssWebServerViewModel)
        {
            InitializeComponent();
        }
    }
}