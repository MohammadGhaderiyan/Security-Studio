using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.Traceroute.ViewModel
{
    public class SsTracerouteViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "traceroute";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}