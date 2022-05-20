using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.Go.ViewModel
{
    public class SsGoViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Go";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}