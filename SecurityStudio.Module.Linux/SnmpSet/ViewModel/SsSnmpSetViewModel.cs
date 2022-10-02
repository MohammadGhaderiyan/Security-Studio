using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.SnmpSet.ViewModel
{
    public class SsSnmpSetViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "snmpset";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}