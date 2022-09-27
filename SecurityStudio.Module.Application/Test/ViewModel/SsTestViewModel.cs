using CliWrap;
using CliWrap.Buffered;
using Rebex.Net;
using Rebex.TerminalEmulation;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Application.Test.ViewModel
{
    public class SsTestViewModel : SsViewModel
    {
        public SsCommand SsTest01Command { get; set; }
        public SsCommand SsTest02Command { get; set; }
        public SsCommand SsTest03Command { get; set; }
        public SsCommand SsTest04Command { get; set; }
        public SsCommand SsTest05Command { get; set; }
        public SsCommand SsTest06Command { get; set; }

        protected override void PrepareSsCommands()
        {
            SsTest01Command = new SsCommand(SsTest01);
            SsTest02Command = new SsCommand(SsTest02);
            SsTest03Command = new SsCommand(SsTest03);
            SsTest04Command = new SsCommand(SsTest04);
            SsTest05Command = new SsCommand(SsTest05);
            SsTest06Command = new SsCommand(SsTest06);
        }

        private async void SsTest01(object obj)
        {
            var cmd1 = Cli.Wrap("cd")
                .WithArguments(@"");
            var cmd2 = Cli.Wrap("type")
                .WithArguments("text.txt")
                .WithWorkingDirectory(@"C:\Users\FarnahadSystem\Desktop\New folder");

            //C:\Windows\System32\cmd.exe

            var result2 = await (cmd2).ExecuteBufferedAsync();
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

        private void SsTest04(object obj)
        {
        }

        private void SsTest05(object obj)
        {
        }

        private void SsTest06(object obj)
        {
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