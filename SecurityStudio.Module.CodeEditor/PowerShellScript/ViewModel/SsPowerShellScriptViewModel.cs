using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.PowerShellScript.ViewModel
{
    public class SsPowerShellScriptViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Power Shell Script";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}