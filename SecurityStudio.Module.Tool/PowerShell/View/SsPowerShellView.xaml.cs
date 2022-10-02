using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.PowerShell.ViewModel;

namespace SecurityStudio.Module.Tool.PowerShell.View
{
    public partial class SsPowerShellView : SsView
    {
        public SsPowerShellView(SsPowerShellViewModel ssPowerShellViewModel)
            : base(ssPowerShellViewModel)
        {
            InitializeComponent();
        }
    }
}