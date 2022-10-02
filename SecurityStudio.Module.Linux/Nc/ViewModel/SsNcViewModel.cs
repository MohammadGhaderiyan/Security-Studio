using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.Nc.ViewModel
{
    public class SsNcViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "nc";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}