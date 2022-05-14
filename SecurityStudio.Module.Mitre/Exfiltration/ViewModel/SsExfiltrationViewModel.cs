using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Mitre.Exfiltration.ViewModel
{
    public class SsExfiltrationViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Exfiltration";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}