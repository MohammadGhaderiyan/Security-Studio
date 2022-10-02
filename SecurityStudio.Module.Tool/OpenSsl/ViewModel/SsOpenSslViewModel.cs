using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.OpenSsl.ViewModel
{
    public class SsOpenSslViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "openssl";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}