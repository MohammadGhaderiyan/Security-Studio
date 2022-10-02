using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.TcpDump.ViewModel
{
    public class SsTcpDumpViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "tcpdump";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}