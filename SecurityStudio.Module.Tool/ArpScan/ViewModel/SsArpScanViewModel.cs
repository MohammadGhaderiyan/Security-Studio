using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.ArpScan.ViewModel
{
    public class SsArpScanViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "arp-scan";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}