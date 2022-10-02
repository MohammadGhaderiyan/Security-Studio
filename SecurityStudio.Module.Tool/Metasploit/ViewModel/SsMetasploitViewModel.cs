using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Metasploit.ViewModel
{
    public class SsMetasploitViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Metasploit";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}