using System.ComponentModel;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Definition.AndroidOperatingSystem;
using SecurityStudio.Service.Main.DateTime;
using SecurityStudio.Service.Main.Parameter;
using SecurityStudio.Service.Main.Window;

namespace SecurityStudio.Module.Definition.AndroidOperatingSystem.ViewModel
{
    public class SsAndroidOperatingSystemViewModel : SsViewModel
    {
        private readonly IAndroidOperatingSystemService _androidOperatingSystemService;
        private readonly IWindowService _windowService;
        private readonly IParameterService _parameterService;
        private readonly IDateTimeService _dateTimeService;

        public SsAndroidOperatingSystemViewModel(
            IAndroidOperatingSystemService androidOperatingSystemService,
            IWindowService windowService, IParameterService parameterService,
            IDateTimeService dateTimeService)
        {
            _androidOperatingSystemService = androidOperatingSystemService;
            _windowService = windowService;
            _parameterService = parameterService;
            _dateTimeService = dateTimeService;
        }

        public SsCommand SsSaveAndroidOperatingSystemCommand { get; set; }
        public SsCommand SsCancelCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsSaveAndroidOperatingSystemCommand = new SsCommand(
                SsSaveAndroidOperatingSystem, CanSsSaveAndroidOperatingSystem);
            SsCancelCommand = new SsCommand(SsCancel);
        }

        private void SsSaveAndroidOperatingSystem(object parameter)
        {
            _androidOperatingSystemService.Save(AndroidOperatingSystem);
            _windowService.Close(this);
        }

        private bool CanSsSaveAndroidOperatingSystem(object parameter)
        {
            return _androidOperatingSystemService.IsValid(AndroidOperatingSystem);
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
            FillAndroidOperatingSystem();
        }

        private void FillAndroidOperatingSystem()
        {
            if (_parameterService.Exist("AndroidOperatingSystemId"))
            {
                var androidOperatingSystemId = _parameterService.GetValue<int>("AndroidOperatingSystemId");
                AndroidOperatingSystem = _androidOperatingSystemService.GetAndroidOperatingSystem(androidOperatingSystemId);
                Title = "Edit Android Operating System";
            }
            else
            {
                AndroidOperatingSystem = new Database.Model.Definition.AndroidOperatingSystem
                {
                    Enable = true
                };
                Title = "Add Android Operating System";
            }

            AndroidOperatingSystem.PropertyChanged += AndroidOperatingSystemOnPropertyChanged;
        }

        private void AndroidOperatingSystemOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SsSaveAndroidOperatingSystemCommand.CheckCanExecuteChanged();
        }

        private Database.Model.Definition.AndroidOperatingSystem _androidOperatingSystem;
        public Database.Model.Definition.AndroidOperatingSystem AndroidOperatingSystem
        {
            get => _androidOperatingSystem;
            set
            {
                _androidOperatingSystem = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
            _androidOperatingSystemService.Dispose();
            _windowService.Dispose();
            _parameterService.Dispose();
            _dateTimeService.Dispose();
        }
    }
}