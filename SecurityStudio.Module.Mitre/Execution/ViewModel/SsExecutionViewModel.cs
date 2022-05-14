using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Mitre.Execution.ViewModel
{
    public class SsExecutionViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Execution";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}