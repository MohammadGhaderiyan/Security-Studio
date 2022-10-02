using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Wazuh.ViewModel;

namespace SecurityStudio.Module.Wiki.Wazuh.View
{
    public partial class SsWazuhView : SsView
    {
        public SsWazuhView(SsWazuhViewModel ssWazuhViewModel)
            : base(ssWazuhViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}