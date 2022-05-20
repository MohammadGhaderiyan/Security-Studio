using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.SansInstitute.ViewModel
{
    public class SsSansInstituteViewModel : SsViewModel
    {
        public SsCommand SsShowSansInstituteCommand { get; set; }
        public SsCommand SsOpenSansInstituteCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSansInstituteCommand = new SsCommand(SsShowSansInstitute);
            SsOpenSansInstituteCommand = new SsCommand(SsOpenSansInstitute);
        }

        private void SsShowSansInstitute(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSansInstitute(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "SANS Institute";
            Uri = _uriAddress = "https://www.sans.org/";
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