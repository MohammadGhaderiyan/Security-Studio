using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.CodeEditor.Php.ViewModel
{
    public class SsPhpViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "PHP";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}