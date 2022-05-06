using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Database.MySql.ViewModel
{
    public class SsMySqlViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "MySQL";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}