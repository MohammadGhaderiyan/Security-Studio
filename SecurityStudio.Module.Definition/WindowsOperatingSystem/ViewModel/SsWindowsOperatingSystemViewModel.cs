using System.ComponentModel;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Base.DateTime;
using SecurityStudio.Service.Base.Parameter;
using SecurityStudio.Service.Base.Window;
using SecurityStudio.Service.Definition.WindowsOperatingSystem;

namespace SecurityStudio.Module.Definition.WindowsOperatingSystem.ViewModel
{
    public class SsWindowsOperatingSystemViewModel : SsViewModel
    {
        private readonly IWindowsOperatingSystemService _windowsOperatingSystemService;
        private readonly IWindowService _windowService;
        private readonly IParameterService _parameterService;
        private readonly IDateTimeService _dateTimeService;

        public SsWindowsOperatingSystemViewModel(
            IWindowsOperatingSystemService windowsOperatingSystemService,
            IWindowService windowService, IParameterService parameterService,
            IDateTimeService dateTimeService)
        {
            _windowsOperatingSystemService = windowsOperatingSystemService;
            _windowService = windowService;
            _parameterService = parameterService;
            _dateTimeService = dateTimeService;
        }

        public SsCommand SsSaveWindowsOperatingSystemCommand { get; set; }
        public SsCommand SsCancelCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsSaveWindowsOperatingSystemCommand = new SsCommand(
                SsSaveWindowsOperatingSystem, CanSsSaveWindowsOperatingSystem);
            SsCancelCommand = new SsCommand(SsCancel);
        }

        private void SsSaveWindowsOperatingSystem(object parameter)
        {
            _windowsOperatingSystemService.Save(WindowsOperatingSystem);
            _windowService.Close(this);
        }

        private bool CanSsSaveWindowsOperatingSystem(object parameter)
        {
            return _windowsOperatingSystemService.IsValid(WindowsOperatingSystem);
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
            FillWindowsOperatingSystem();
        }

        private void FillWindowsOperatingSystem()
        {
            if (_parameterService.Exist("WindowsOperatingSystemId"))
            {
                var windowsOperatingSystemId = _parameterService.GetValue<int>("WindowsOperatingSystemId");
                WindowsOperatingSystem = _windowsOperatingSystemService.GetWindowsOperatingSystem(windowsOperatingSystemId);
                Title = "Edit Windows Operating System";
            }
            else
            {
                WindowsOperatingSystem = new Database.Model.Definition.WindowsOperatingSystem
                {
                    Enable = true
                };
                Title = "Add Windows Operating System";
            }

            WindowsOperatingSystem.PropertyChanged += WindowsOperatingSystemOnPropertyChanged;
        }

        private void WindowsOperatingSystemOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SsSaveWindowsOperatingSystemCommand.RaiseCanExecuteChanged();
        }

        private Database.Model.Definition.WindowsOperatingSystem _windowsOperatingSystem;
        public Database.Model.Definition.WindowsOperatingSystem WindowsOperatingSystem
        {
            get => _windowsOperatingSystem;
            set
            {
                _windowsOperatingSystem = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
            _windowsOperatingSystemService.Dispose();
            _windowService.Dispose();
            _parameterService.Dispose();
            _dateTimeService.Dispose();
        }
    }
}