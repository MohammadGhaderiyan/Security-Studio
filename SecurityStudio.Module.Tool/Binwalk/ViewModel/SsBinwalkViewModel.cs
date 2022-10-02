using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Binwalk.ViewModel
{
    public class SsBinwalkViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "binwalk";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}