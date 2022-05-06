using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.BashScript.ViewModel
{
    public class SsBashScriptViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Bash Script";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}