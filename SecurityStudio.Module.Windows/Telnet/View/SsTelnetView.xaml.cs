using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.Telnet.ViewModel;

namespace SecurityStudio.Module.Windows.Telnet.View
{
    public partial class SsTelnetView : SsView
    {
        public SsTelnetView(SsTelnetViewModel ssTelnetViewModel)
            : base(ssTelnetViewModel)
        {
            InitializeComponent();
        }
    }
}