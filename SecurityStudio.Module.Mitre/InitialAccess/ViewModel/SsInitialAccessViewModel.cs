using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Mitre.InitialAccess.ViewModel
{
    public class SsInitialAccessViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Initial Access";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}