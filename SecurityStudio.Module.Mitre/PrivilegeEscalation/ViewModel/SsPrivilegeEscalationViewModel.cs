using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Mitre.PrivilegeEscalation.ViewModel
{
    public class SsPrivilegeEscalationViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Privilege Escalation";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}