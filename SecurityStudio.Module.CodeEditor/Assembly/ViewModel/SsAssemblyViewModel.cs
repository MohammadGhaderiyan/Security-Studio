using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.Assembly.ViewModel
{
    public class SsAssemblyViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Assembly";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}