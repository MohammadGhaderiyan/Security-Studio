using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Database.SqlServer.ViewModel
{
    public class SsSqlServerViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "SQL Server";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}