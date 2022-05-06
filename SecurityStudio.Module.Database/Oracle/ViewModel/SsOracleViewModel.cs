using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Database.Oracle.ViewModel
{
    public class SsOracleViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Oracle";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}