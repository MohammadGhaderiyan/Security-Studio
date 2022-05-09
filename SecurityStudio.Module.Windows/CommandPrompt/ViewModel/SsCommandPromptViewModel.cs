using ConsoleControlAPI;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Windows.Utility;
using SecurityStudio.Service.Main.Session;

namespace SecurityStudio.Module.Windows.CommandPrompt.ViewModel
{
    public class SsCommandPromptViewModel : SsViewModel
    {
        private readonly ISessionService _sessionService;

        public SsCommandPromptViewModel(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public SsCommand SsStartProcessCommand { get; set; }
        public SsCommand SsStopProcessCommand { get; set; }
        public SsCommand SsClearCommand { get; set; }
        public SsCommand SsOpenCommandPromptCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsStartProcessCommand = new SsCommand(SsStartProcess);
            SsStopProcessCommand = new SsCommand(SsStopProcess);
            SsClearCommand = new SsCommand(SsClear);
            SsOpenCommandPromptCommand = new SsCommand(SsOpenCommandPrompt);
        }

        private void SsStartProcess(object parameter)
        {
            ConsoleControl.StartProcess("cmd.exe", null);
        }

        private void SsStopProcess(object parameter)
        {
            ConsoleControl.StopProcess();
        }

        private void SsClear(object parameter)
        {
            ConsoleControl.ClearOutput();
        }

        private void SsOpenCommandPrompt(object parameter)
        {
            _utilityWindowsTool.OpenCommandPrompt();
        }

        private UtilityWindowsTool _utilityWindowsTool;

        protected override void PrepareVariables()
        {
            Title = "Command Prompt";
            _utilityWindowsTool = new UtilityWindowsTool(_sessionService.WindowsOperatingSystem);
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
                    SsStartProcess(null);
                }
            }
        }

        private void ConsoleControlOnOnProcessInput(object sender, ProcessEventArgs args)
        {
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