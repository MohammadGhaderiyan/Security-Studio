using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Main.Test.ViewModel
{
    public class SsTestViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {

        }

        protected override void PrepareVariables()
        {
            Title = "Test";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}