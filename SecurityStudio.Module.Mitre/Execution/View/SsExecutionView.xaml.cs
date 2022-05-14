using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Execution.ViewModel;

namespace SecurityStudio.Module.Mitre.Execution.View
{
    public partial class SsExecutionView : SsView
    {
        public SsExecutionView(SsExecutionViewModel ssExecutionViewModel)
            : base(ssExecutionViewModel)
        {
            InitializeComponent();
        }
    }
}