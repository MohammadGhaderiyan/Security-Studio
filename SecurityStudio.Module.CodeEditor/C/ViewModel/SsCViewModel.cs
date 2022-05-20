using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.C.ViewModel
{
    public class SsCViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "C";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}