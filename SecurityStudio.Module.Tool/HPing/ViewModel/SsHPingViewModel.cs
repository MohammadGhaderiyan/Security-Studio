using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.HPing.ViewModel
{
    public class SsHPingViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "hping";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}