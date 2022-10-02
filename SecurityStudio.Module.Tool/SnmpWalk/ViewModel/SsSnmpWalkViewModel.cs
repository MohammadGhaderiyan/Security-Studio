using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.SnmpWalk.ViewModel
{
    public class SsSnmpWalkViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "snmpwalk";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}