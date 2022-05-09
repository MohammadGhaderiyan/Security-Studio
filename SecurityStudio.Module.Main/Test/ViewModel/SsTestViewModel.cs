using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;
using Rebex.Net;
using Rebex.TerminalEmulation;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Main.Test.ViewModel
{
    public class SsTestViewModel : SsViewModel
    {
        public SsCommand SsTest01Command { get; set; }
        public SsCommand SsTest02Command { get; set; }
        public SsCommand SsTest03Command { get; set; }

        protected override void PrepareSsCommands()
        {
            SsTest01Command = new SsCommand(SsTest01);
            SsTest02Command = new SsCommand(SsTest02);
            SsTest03Command = new SsCommand(SsTest03);
        }

        private async void SsTest01(object obj)
        {
            var cmd = Cli.Wrap("ipconfig");

            var result1 = await cmd.ExecuteAsync();
            var result2 = await cmd.ExecuteBufferedAsync();
        }

        private void SsTest02(object obj)
        {
            System.Diagnostics.Process.Start("CMD.exe", " C:\\");
        }

        Ssh ssh = new Ssh();

        private void SsTest03(object obj)
        {
            ssh.Connect("192.168.15.134", 22);
            ssh.Login("kali", "kali");
            
            ssh.StartShell(ShellMode.Prompt);

            ssh.StartScripting("ifconfig");
            ssh.StartVirtualTerminal();


            
            var ppp = ssh.RunCommand("ifconfig");
        }

        protected override void PrepareVariables()
        {
            Title = "Test";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}