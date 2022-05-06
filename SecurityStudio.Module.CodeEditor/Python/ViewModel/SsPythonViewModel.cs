using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.Python.ViewModel
{
    public class SsPythonViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Python";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}