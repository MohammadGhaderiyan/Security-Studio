using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.LeakLookup.ViewModel
{
    public class SsLeakLookupViewModel : SsViewModel
    {
        public SsCommand SsShowLeakLookupCommand { get; set; }
        public SsCommand SsOpenLeakLookupCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowLeakLookupCommand = new SsCommand(SsShowLeakLookup);
            SsOpenLeakLookupCommand = new SsCommand(SsOpenLeakLookup);
        }

        private void SsShowLeakLookup(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenLeakLookup(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Leak-Lookup";
            Uri = _uriAddress = "https://leak-lookup.com/";
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