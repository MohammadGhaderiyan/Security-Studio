using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.CPlusPlus.ViewModel
{
    public class SsCPlusPlusViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "C++";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}