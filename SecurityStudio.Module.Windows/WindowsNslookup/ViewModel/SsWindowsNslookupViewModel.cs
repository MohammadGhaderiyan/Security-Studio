using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Windows.WindowsNslookup.ViewModel
{
    public class SsWindowsNslookupViewModel : SsViewModel
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