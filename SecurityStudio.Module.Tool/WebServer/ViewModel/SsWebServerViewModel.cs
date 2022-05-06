using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.WebServer.ViewModel
{
    public class SsWebServerViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Web Server";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}