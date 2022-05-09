using System.Windows.Media;
using ConsoleControlAPI;
using SecurityStudio.Base.Linux;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Main.Session;

namespace SecurityStudio.Module.Linux.Terminal.ViewModel
{
    public class SsTerminalViewModel : SsViewModel
    {
        private readonly ISessionService _sessionService;

        public SsTerminalViewModel(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public SsCommand SsClearCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsClearCommand = new SsCommand(SsClear);
        }

        private void SsClear(object parameter)
        {
            ConsoleControl.ClearOutput();
        }

        private ConsoleControl.WPF.ConsoleControl _consoleControl;
        public ConsoleControl.WPF.ConsoleControl ConsoleControl
        {
            get => _consoleControl;
            set
            {
                _consoleControl = value;

                if (ConsoleControl != null)
                {
                    ConsoleControl.OnProcessInput += ConsoleControlOnOnProcessInput;
                    ConsoleControl.OnProcessOutput += ConsoleControlOnOnProcessOutput;
                }
            }
        }

        private LinuxEngine _linuxEngine;

        protected override void PrepareVariables()
        {
            _linuxEngine = new LinuxEngine(_sessionService.LinuxOperatingSystem);
            Title = "Terminal";
        }

        private async void ConsoleControlOnOnProcessInput(object sender, ProcessEventArgs args)
        {
            ConsoleControl.WriteOutput(await _linuxEngine.GetCommand(args.Content), Colors.Blue);
        }

        private void ConsoleControlOnOnProcessOutput(object sender, ProcessEventArgs args)
        {
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}