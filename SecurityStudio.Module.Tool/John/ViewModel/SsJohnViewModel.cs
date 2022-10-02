using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.John.ViewModel
{
    public class SsJohnViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "john";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}