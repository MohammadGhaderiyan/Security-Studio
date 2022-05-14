using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Mitre.Persistence.ViewModel
{
    public class SsPersistenceViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Persistence";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}