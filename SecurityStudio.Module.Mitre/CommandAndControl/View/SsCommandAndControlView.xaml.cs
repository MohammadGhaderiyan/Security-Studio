using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.CommandAndControl.ViewModel;

namespace SecurityStudio.Module.Mitre.CommandAndControl.View
{
    public partial class SsCommandAndControlView : SsView
    {
        public SsCommandAndControlView(SsCommandAndControlViewModel ssCommandAndControlViewModel)
            : base(ssCommandAndControlViewModel)
        {
            InitializeComponent();
        }
    }
}