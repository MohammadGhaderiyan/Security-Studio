using System.Collections.ObjectModel;
using System.Linq;
using SecurityStudio.Base.Main.Model;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.LinuxOperatingSystem.View;
using SecurityStudio.Service.Definition.LinuxOperatingSystem;
using SecurityStudio.Service.Main.MessageBox;
using SecurityStudio.Service.Main.Parameter;
using SecurityStudio.Service.Main.Window;

namespace SecurityStudio.Module.Definition.LinuxOperatingSystem.ViewModel
{
    public class SsLinuxOperatingSystemListViewModel : SsViewModel
    {
        private readonly ILinuxOperatingSystemService _linuxOperatingSystemService;
        private readonly IWindowService _windowService;
        private readonly IParameterService _parameterService;
        private readonly IMessageBoxService _messageBoxService;

        public SsLinuxOperatingSystemListViewModel(ILinuxOperatingSystemService linuxOperatingSystemService,
            IWindowService windowService, IParameterService parameterService,
            IMessageBoxService messageBoxService)
        {
            _linuxOperatingSystemService = linuxOperatingSystemService;
            _windowService = windowService;
            _parameterService = parameterService;
            _messageBoxService = messageBoxService;
        }

        public SsCommand SsSearchCommand { get; set; }
        public SsCommand SsAddLinuxOperatingSystemCommand { get; set; }
        public SsCommand SsEditLinuxOperatingSystemCommand { get; set; }
        public SsCommand SsDeleteLinuxOperatingSystemCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsSearchCommand = new SsCommand(SsSearch);
            SsAddLinuxOperatingSystemCommand = new SsCommand(SsAddLinuxOperatingSystem);
            SsEditLinuxOperatingSystemCommand = new SsCommand(
                SsEditLinuxOperatingSystem, CanSsEditLinuxOperatingSystem);
            SsDeleteLinuxOperatingSystemCommand = new SsCommand(
                SsDeleteLinuxOperatingSystem, CanSsDeleteLinuxOperatingSystem);
        }

        private void SsSearch(object parameter)
        {
            FillLinuxOperatingSystems();
        }

        private void SsAddLinuxOperatingSystem(object parameter)
        {
            _windowService.ShowDialogSsView<SsLinuxOperatingSystemView>();
            FillLinuxOperatingSystems();
        }

        private void SsEditLinuxOperatingSystem(object parameter)
        {
            _parameterService.SetValue("LinuxOperatingSystemId", CurrentLinuxOperatingSystem.Id);
            _windowService.ShowDialogSsView<SsLinuxOperatingSystemView>();
            FillLinuxOperatingSystems();
        }

        private bool CanSsEditLinuxOperatingSystem(object parameter)
        {
            return CurrentLinuxOperatingSystem != null;
        }

        private void SsDeleteLinuxOperatingSystem(object parameter)
        {
            if (_messageBoxService.ShowDeleteYesNoQuestion(ModelName.LinuxOperatingSystem))
            {
                _linuxOperatingSystemService.Delete(CurrentLinuxOperatingSystem);
                LinuxOperatingSystems.Remove(CurrentLinuxOperatingSystem);
                FillLinuxOperatingSystems();
            }
        }

        private bool CanSsDeleteLinuxOperatingSystem(object parameter)
        {
            return CurrentLinuxOperatingSystem != null;
        }

        protected override void PrepareVariables()
        {
            Title = "Linux Operating Systems";
        }

        protected override void FillData()
        {
            FillLinuxOperatingSystems();
        }

        private void FillLinuxOperatingSystems()
        {
            int? currentLinuxOperatingSystemId = null;
            if (CurrentLinuxOperatingSystem != null)
                currentLinuxOperatingSystemId = CurrentLinuxOperatingSystem.Id;

            LinuxOperatingSystems = new ObservableCollection<Database.Model.Definition.LinuxOperatingSystem>(
                _linuxOperatingSystemService.GetLinuxOperatingSystems());

            CurrentLinuxOperatingSystem = currentLinuxOperatingSystemId != null ? LinuxOperatingSystems.FirstOrDefault(
                item => item.Id == currentLinuxOperatingSystemId.Value) : LinuxOperatingSystems.FirstOrDefault();
        }

        private string _search;
        public string Search
        {
            get => _search;
            set
            {
                _search = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Database.Model.Definition.LinuxOperatingSystem> _linuxOperatingSystems;
        public ObservableCollection<Database.Model.Definition.LinuxOperatingSystem> LinuxOperatingSystems
        {
            get => _linuxOperatingSystems;
            set
            {
                _linuxOperatingSystems = value;
                OnPropertyChanged();
            }
        }

        private Database.Model.Definition.LinuxOperatingSystem _currentLinuxOperatingSystem;
        public Database.Model.Definition.LinuxOperatingSystem CurrentLinuxOperatingSystem
        {
            get => _currentLinuxOperatingSystem;
            set
            {
                _currentLinuxOperatingSystem = value;
                OnPropertyChanged();
                SsEditLinuxOperatingSystemCommand.CheckCanExecuteChanged();
                SsDeleteLinuxOperatingSystemCommand.CheckCanExecuteChanged();
            }
        }

        public override void Dispose()
        {
            _linuxOperatingSystemService.Dispose();
            _windowService.Dispose();
            _parameterService.Dispose();
            _messageBoxService.Dispose();
        }
    }
}