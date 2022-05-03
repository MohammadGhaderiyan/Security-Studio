using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.PowerShellScript.ViewModel;

namespace SecurityStudio.Module.CodeEditor.PowerShellScript.View
{
    public partial class SsPowerShellScriptView : SsView
    {
        public SsPowerShellScriptView(SsPowerShellScriptViewModel ssPowerShellScriptViewModel)
            : base(ssPowerShellScriptViewModel)
        {
            InitializeComponent();
        }
    }
}