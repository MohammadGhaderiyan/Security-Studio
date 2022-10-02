using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.SqlMap.ViewModel
{
    public class SsSqlMapViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "sqlmap";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}