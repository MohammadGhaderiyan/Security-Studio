using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Windows.CommandPrompt.ViewModel
{
    public class SsCommandPromptViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Command Prompt";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}