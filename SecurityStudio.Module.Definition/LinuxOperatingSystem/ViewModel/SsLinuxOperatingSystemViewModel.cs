using System.ComponentModel;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Base.DateTime;
using SecurityStudio.Service.Base.Parameter;
using SecurityStudio.Service.Base.Window;
using SecurityStudio.Service.Definition.LinuxOperatingSystem;

namespace SecurityStudio.Module.Definition.LinuxOperatingSystem.ViewModel
{
    public class SsLinuxOperatingSystemViewModel : SsViewModel
    {
        private readonly ILinuxOperatingSystemService _linuxOperatingSystemService;
        private readonly IWindowService _windowService;
        private readonly IParameterService _parameterService;
        private readonly IDateTimeService _dateTimeService;

        public SsLinuxOperatingSystemViewModel(
            ILinuxOperatingSystemService linuxOperatingSystemService,
            IWindowService windowService, IParameterService parameterService,
            IDateTimeService dateTimeService)
        {
            _linuxOperatingSystemService = linuxOperatingSystemService;
            _windowService = windowService;
            _parameterService = parameterService;
            _dateTimeService = dateTimeService;
        }

        public SsCommand SsSaveLinuxOperatingSystemCommand { get; set; }
        public SsCommand SsCancelCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsSaveLinuxOperatingSystemCommand = new SsCommand(
                SsSaveLinuxOperatingSystem, CanSsSaveLinuxOperatingSystem);
            SsCancelCommand = new SsCommand(SsCancel);
        }

        private void SsSaveLinuxOperatingSystem(object parameter)
        {
            _linuxOperatingSystemService.Save(LinuxOperatingSystem);
            _windowService.Close(this);
        }

        private bool CanSsSaveLinuxOperatingSystem(object parameter)
        {
            return _linuxOperatingSystemService.IsValid(LinuxOperatingSystem);
        }

        private void SsCancel(object parameter)
        {
            _windowService.Close(this);
        }

        protected override void PrepareVariables()
        {
        }

        protected override void FillData()
        {
            FillLinuxOperatingSystem();
        }

        private void FillLinuxOperatingSystem()
        {
            if (_parameterService.Exist("LinuxOperatingSystemId"))
            {
                var linuxOperatingSystemId = _parameterService.GetValue<int>("LinuxOperatingSystemId");
                LinuxOperatingSystem = _linuxOperatingSystemService.GetLinuxOperatingSystem(linuxOperatingSystemId);
                Title = "Edit Linux Operating System";
            }
            else
            {
                LinuxOperatingSystem = new Database.Model.Definition.LinuxOperatingSystem
                {
                    Enable = true
                };
                Title = "Add Linux Operating System";
            }

            LinuxOperatingSystem.PropertyChanged += LinuxOperatingSystemOnPropertyChanged;
        }

        private void LinuxOperatingSystemOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SsSaveLinuxOperatingSystemCommand.RaiseCanExecuteChanged();
        }

        private Database.Model.Definition.LinuxOperatingSystem _linuxOperatingSystem;
        public Database.Model.Definition.LinuxOperatingSystem LinuxOperatingSystem
        {
            get => _linuxOperatingSystem;
            set
            {
                _linuxOperatingSystem = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
            _linuxOperatingSystemService.Dispose();
            _windowService.Dispose();
            _parameterService.Dispose();
            _dateTimeService.Dispose();
        }
    }
}