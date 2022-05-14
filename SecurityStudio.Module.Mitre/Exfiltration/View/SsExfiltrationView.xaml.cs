using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Exfiltration.ViewModel;

namespace SecurityStudio.Module.Mitre.Exfiltration.View
{
    public partial class SsExfiltrationView : SsView
    {
        public SsExfiltrationView(SsExfiltrationViewModel ssExfiltrationViewModel)
            : base(ssExfiltrationViewModel)
        {
            InitializeComponent();
        }
    }
}