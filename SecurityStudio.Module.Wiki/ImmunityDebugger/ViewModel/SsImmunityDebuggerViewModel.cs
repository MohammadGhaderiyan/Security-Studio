using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.ImmunityDebugger.ViewModel
{
    public class SsImmunityDebuggerViewModel : SsViewModel
    {
        public SsCommand SsShowImmunityDebuggerCommand { get; set; }
        public SsCommand SsOpenImmunityDebuggerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowImmunityDebuggerCommand = new SsCommand(SsShowImmunityDebugger);
            SsOpenImmunityDebuggerCommand = new SsCommand(SsOpenImmunityDebugger);
        }

        private void SsShowImmunityDebugger(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenImmunityDebugger(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Immunity Debugger";
            Uri = _uriAddress = "https://www.immunityinc.com/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private string _uri;
        public string Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}