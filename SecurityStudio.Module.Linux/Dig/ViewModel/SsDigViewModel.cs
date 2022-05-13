using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.Dig.ViewModel
{
    public class SsDigViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "dig";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}