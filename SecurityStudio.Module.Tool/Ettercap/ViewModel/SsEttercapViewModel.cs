using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Ettercap.ViewModel
{
    public class SsEttercapViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "ettercap";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}