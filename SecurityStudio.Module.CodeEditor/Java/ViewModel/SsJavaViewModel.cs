using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.Java.ViewModel
{
    public class SsJavaViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Java";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}