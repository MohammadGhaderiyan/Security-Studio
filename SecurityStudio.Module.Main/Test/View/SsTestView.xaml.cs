using System.Windows.Media;
using ConsoleControlAPI;
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

        public override void SsViewLoaded()
        {
            if (!ssh.IsConnected)
            {
                ssh.Connect("192.168.15.134", 22);
                ssh.Login("kali", "kali");
            }
        }

        Ssh ssh = new Ssh();

        private void ConsoleControl_OnOnProcessInput(object sender, ProcessEventArgs args)
        {
            var result = ssh.RunCommand(args.Content);
            ConsoleControl.WriteOutput(result, Colors.Red);
        }

        private void ConsoleControl_OnOnProcessOutput(object sender, ProcessEventArgs args)
        {
        }
    }
}