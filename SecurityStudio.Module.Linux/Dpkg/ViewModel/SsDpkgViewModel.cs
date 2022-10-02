using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.Dpkg.ViewModel
{
    public class SsDpkgViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "dpkg";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}