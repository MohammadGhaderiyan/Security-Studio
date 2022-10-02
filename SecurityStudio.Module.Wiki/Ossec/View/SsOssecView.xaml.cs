using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Ossec.ViewModel;

namespace SecurityStudio.Module.Wiki.Ossec.View
{
    public partial class SsOssecView : SsView
    {
        public SsOssecView(SsOssecViewModel ssOssecViewModel)
            : base(ssOssecViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}