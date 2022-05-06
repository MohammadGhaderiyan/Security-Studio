using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.BatchScript.ViewModel
{
    public class SsBatchScriptViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Batch Script";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}