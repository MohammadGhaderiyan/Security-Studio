using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Nmap.ViewModel
{
    public class SsNmapViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Nmap";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}