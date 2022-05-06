using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Mimikatz.ViewModel
{
    public class SsMimikatzViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Mimikatz";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}