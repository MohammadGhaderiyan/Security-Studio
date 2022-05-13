using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Windows.WindowsPing.ViewModel
{
    public class SsWindowsPingViewModel : SsViewModel
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