using Rebex.Net;
using Rebex.TerminalEmulation;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Test.ViewModel;

namespace SecurityStudio.Module.Main.Test.View
{
    public partial class SsTestView : SsView
    {
        public SsTestView(SsTestViewModel ssTestViewModel)
            : base(ssTestViewModel)
        {
            InitializeComponent();
        }

        public TerminalControl TerminalControl { get; set; }

        public override void SsViewLoaded()
        {
            //TerminalControl = new TerminalControl();

            //var ssh = new Ssh();
            //ssh.Connect("192.168.15.134", 22);
            //ssh.Login("kali", "kali");
            //TerminalControl.Bind(ssh);

            //WindowsFormsHostMain.Child = TerminalControl;
        }
    }
}