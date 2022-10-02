using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.PsExec.ViewModel;

namespace SecurityStudio.Module.Tool.PsExec.View
{
    public partial class SsPsExecView : SsView
    {
        public SsPsExecView(SsPsExecViewModel ssPsExecViewModel)
            : base(ssPsExecViewModel)
        {
            InitializeComponent();
        }
    }
}