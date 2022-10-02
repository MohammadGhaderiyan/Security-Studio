using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.SnmpCheck.ViewModel
{
    public class SsSnmpCheckViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "snmpcheck";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}