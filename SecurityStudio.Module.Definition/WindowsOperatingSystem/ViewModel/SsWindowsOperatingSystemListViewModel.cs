using System.Collections.ObjectModel;
using System.Linq;
using SecurityStudio.Base.Main.Model;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.WindowsOperatingSystem.View;
using SecurityStudio.Service.Definition.WindowsOperatingSystem;
using SecurityStudio.Service.Main.MessageBox;
using SecurityStudio.Service.Main.Parameter;
using SecurityStudio.Service.Main.Window;

namespace SecurityStudio.Module.Definition.WindowsOperatingSystem.ViewModel
{
    public class SsWindowsOperatingSystemListViewModel : SsViewModel
    {
        private readonly IWindowsOperatingSystemService _windowsOperatingSystemService;
        private readonly IWindowService _windowService;
        private readonly IParameterService _parameterService;
        private readonly IMessageBoxService _messageBoxService;

        public SsWindowsOperatingSystemListViewModel(IWindowsOperatingSystemService windowsOperatingSystemService,
            IWindowService windowService, IParameterService parameterService,
            IMessageBoxService messageBoxService)
        {
            _windowsOperatingSystemService = windowsOperatingSystemService;
            _windowService = windowService;
            _parameterService = parameterService;
            _messageBoxService = messageBoxService;
        }

        public SsCommand SsSearchCommand { get; set; }
        public SsCommand SsAddWindowsOperatingSystemCommand { get; set; }
        public SsCommand SsEditWindowsOperatingSystemCommand { get; set; }
        public SsCommand SsDeleteWindowsOperatingSystemCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsSearchCommand = new SsCommand(SsSearch);
            SsAddWindowsOperatingSystemCommand = new SsCommand(SsAddWindowsOperatingSystem);
            SsEditWindowsOperatingSystemCommand = new SsCommand(
                SsEditWindowsOperatingSystem, CanSsEditWindowsOperatingSystem);
            SsDeleteWindowsOperatingSystemCommand = new SsCommand(
                SsDeleteWindowsOperatingSystem, CanSsDeleteWindowsOperatingSystem);
        }

        private void SsSearch(object parameter)
        {
            FillWindowsOperatingSystems();
        }

        private void SsAddWindowsOperatingSystem(object parameter)
        {
            _windowService.ShowDialogSsView<SsWindowsOperatingSystemView>();
            FillWindowsOperatingSystems();
        }

        private void SsEditWindowsOperatingSystem(object parameter)
        {
            _parameterService.SetValue("WindowsOperatingSystemId", CurrentWindowsOperatingSystem.Id);
            _windowService.ShowDialogSsView<SsWindowsOperatingSystemView>();
            FillWindowsOperatingSystems();
        }

        private bool CanSsEditWindowsOperatingSystem(object parameter)
        {
            return CurrentWindowsOperatingSystem != null;
        }

        private void SsDeleteWindowsOperatingSystem(object parameter)
        {
            if (_messageBoxService.ShowDeleteYesNoQuestion(ModelName.WindowsOperatingSystem))
            {
                _windowsOperatingSystemService.Delete(CurrentWindowsOperatingSystem);
                WindowsOperatingSystems.Remove(CurrentWindowsOperatingSystem);
                FillWindowsOperatingSystems();
            }
        }

        private bool CanSsDeleteWindowsOperatingSystem(object parameter)
        {
            return CurrentWindowsOperatingSystem != null;
        }

        protected override void PrepareVariables()
        {
            Title = "Windows Operating Systems";
        }

        protected override void FillData()
        {
            FillWindowsOperatingSystems();
        }

        private void FillWindowsOperatingSystems()
        {
            int? currentWindowsOperatingSystemId = null;
            if (CurrentWindowsOperatingSystem != null)
                currentWindowsOperatingSystemId = CurrentWindowsOperatingSystem.Id;

            WindowsOperatingSystems = new ObservableCollection<Database.Model.Definition.WindowsOperatingSystem>(
                _windowsOperatingSystemService.GetWindowsOperatingSystems());

            CurrentWindowsOperatingSystem = currentWindowsOperatingSystemId != null ? WindowsOperatingSystems.FirstOrDefault(
                item => item.Id == currentWindowsOperatingSystemId.Value) : WindowsOperatingSystems.FirstOrDefault();
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

        private ObservableCollection<Database.Model.Definition.WindowsOperatingSystem> _windowsOperatingSystems;
        public ObservableCollection<Database.Model.Definition.WindowsOperatingSystem> WindowsOperatingSystems
        {
            get => _windowsOperatingSystems;
            set
            {
                _windowsOperatingSystems = value;
                OnPropertyChanged();
            }
        }

        private Database.Model.Definition.WindowsOperatingSystem _currentWindowsOperatingSystem;
        public Database.Model.Definition.WindowsOperatingSystem CurrentWindowsOperatingSystem
        {
            get => _currentWindowsOperatingSystem;
            set
            {
                _currentWindowsOperatingSystem = value;
                OnPropertyChanged();
                SsEditWindowsOperatingSystemCommand.CheckCanExecuteChanged();
                SsDeleteWindowsOperatingSystemCommand.CheckCanExecuteChanged();
            }
        }

        public override void Dispose()
        {
            _windowsOperatingSystemService.Dispose();
            _windowService.Dispose();
            _parameterService.Dispose();
            _messageBoxService.Dispose();
        }
    }
}