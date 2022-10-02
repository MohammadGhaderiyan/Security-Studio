using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.PsTools.ViewModel;

namespace SecurityStudio.Module.Tool.PsTools.View
{
    public partial class SsPsToolsView : SsView
    {
        public SsPsToolsView(SsPsToolsViewModel ssPsToolsViewModel)
            : base(ssPsToolsViewModel)
        {
            InitializeComponent();
        }
    }
}