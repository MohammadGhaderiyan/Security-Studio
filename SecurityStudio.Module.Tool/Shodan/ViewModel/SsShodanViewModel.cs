using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Shodan.ViewModel
{
    public class SsShodanViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Shodan";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}