using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Windows.Telnet.ViewModel
{
    public class SsTelnetViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "telnet";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}