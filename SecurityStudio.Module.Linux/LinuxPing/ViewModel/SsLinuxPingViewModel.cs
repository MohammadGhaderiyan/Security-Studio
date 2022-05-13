using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.LinuxPing.ViewModel
{
    public class SsLinuxPingViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "ping";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}