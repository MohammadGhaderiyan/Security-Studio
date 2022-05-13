using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.LinuxNslookup.ViewModel
{
    public class SsLinuxNslookupViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "nslookup";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}