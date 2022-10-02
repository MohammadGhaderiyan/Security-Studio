using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.PsExec.ViewModel
{
    public class SsPsExecViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "PsExec";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}