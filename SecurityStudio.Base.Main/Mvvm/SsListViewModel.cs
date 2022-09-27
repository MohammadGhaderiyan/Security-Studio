//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Threading.Tasks;
//using SecurityStudio.Base.Main.Database;
//using SecurityStudio.Base.Main.Model;
//using SecurityStudio.Service.Definition.AndroidOperatingSystem;

//XXXXXXXXXXXXXXXXXXXXXXXXXX
//namespace SecurityStudio.Base.Main.Mvvm
//{
//    public class SsListViewModel<T> : SsViewModel where T : BaseEntity
//    {
//        private readonly IAndroidOperatingSystemService _androidOperatingSystemService;
//        private readonly IWindowService _windowService;
//        private readonly IParameterService _parameterService;
//        private readonly IMessageBoxService _messageBoxService;

//        public SsListViewModel(IAndroidOperatingSystemService androidOperatingSystemService,
//            IWindowService windowService, IParameterService parameterService,
//            IMessageBoxService messageBoxService)
//        {
//            _androidOperatingSystemService = androidOperatingSystemService;
//            _windowService = windowService;
//            _parameterService = parameterService;
//            _messageBoxService = messageBoxService;
//        }

//        public SsCommand SsSearchCommand { get; set; }
//        public SsCommand SsAddAndroidOperatingSystemCommand { get; set; }
//        public SsCommand SsEditAndroidOperatingSystemCommand { get; set; }
//        public SsCommand SsDeleteAndroidOperatingSystemCommand { get; set; }

//        protected override void PrepareSsCommands()
//        {
//            SsSearchCommand = new SsCommand(SsSearch);
//            SsAddAndroidOperatingSystemCommand = new SsCommand(SsAddAndroidOperatingSystem);
//            SsEditAndroidOperatingSystemCommand = new SsCommand(
//                SsEditAndroidOperatingSystem, CanSsEditAndroidOperatingSystem);
//            SsDeleteAndroidOperatingSystemCommand = new SsCommand(
//                SsDeleteAndroidOperatingSystem, CanSsDeleteAndroidOperatingSystem);
//        }

//        private async Task SsSearch(object parameter)
//        {
//            await Task.Run(FillAndroidOperatingSystems);
//        }

//        private async Task SsAddAndroidOperatingSystem(object parameter)
//        {
//            await Task.Run(() =>
//            {
//                _windowService.ShowDialogSsView<SsAndroidOperatingSystemView>();
//                FillAndroidOperatingSystems();
//            });
//        }

//        private void SsEditAndroidOperatingSystem(object parameter)
//        {
//            _parameterService.SetValue("AndroidOperatingSystemId", CurrentAndroidOperatingSystem.Id);
//            _windowService.ShowDialogSsView<SsAndroidOperatingSystemView>();
//            FillAndroidOperatingSystems();
//        }

//        private bool CanSsEditAndroidOperatingSystem(object parameter)
//        {
//            return CurrentAndroidOperatingSystem != null;
//        }

//        private void SsDeleteAndroidOperatingSystem(object parameter)
//        {
//            if (_messageBoxService.ShowDeleteYesNoQuestion(ModelName.AndroidOperatingSystem))
//            {
//                _androidOperatingSystemService.Delete(CurrentAndroidOperatingSystem);
//                AndroidOperatingSystems.Remove(CurrentAndroidOperatingSystem);
//                FillAndroidOperatingSystems();
//            }
//        }

//        private bool CanSsDeleteAndroidOperatingSystem(object parameter)
//        {
//            return CurrentAndroidOperatingSystem != null;
//        }

//        protected override void PrepareVariables()
//        {
//            Title = "Android Operating Systems";
//        }

//        protected override void FillData()
//        {
//            FillAndroidOperatingSystems();
//        }

//        private void FillAndroidOperatingSystems()
//        {
//            int? currentAndroidOperatingSystemId = null;
//            if (CurrentAndroidOperatingSystem != null)
//                currentAndroidOperatingSystemId = CurrentAndroidOperatingSystem.Id;

//            AndroidOperatingSystems = new ObservableCollection<Database.Model.Definition.AndroidOperatingSystem>(
//                _androidOperatingSystemService.GetAndroidOperatingSystems());

//            CurrentAndroidOperatingSystem = currentAndroidOperatingSystemId != null ? AndroidOperatingSystems.FirstOrDefault(
//                item => item.Id == currentAndroidOperatingSystemId.Value) : AndroidOperatingSystems.FirstOrDefault();
//        }

//        private string _search;
//        public string Search
//        {
//            get => _search;
//            set
//            {
//                _search = value;
//                OnPropertyChanged();
//            }
//        }

//        private ObservableCollection<Database.Model.Definition.AndroidOperatingSystem> _androidOperatingSystems;
//        public ObservableCollection<Database.Model.Definition.AndroidOperatingSystem> AndroidOperatingSystems
//        {
//            get => _androidOperatingSystems;
//            set
//            {
//                _androidOperatingSystems = value;
//                OnPropertyChanged();
//            }
//        }

//        private Database.Model.Definition.AndroidOperatingSystem _currentAndroidOperatingSystem;
//        public Database.Model.Definition.AndroidOperatingSystem CurrentAndroidOperatingSystem
//        {
//            get => _currentAndroidOperatingSystem;
//            set
//            {
//                _currentAndroidOperatingSystem = value;
//                OnPropertyChanged();
//                SsEditAndroidOperatingSystemCommand.RaiseCanExecuteChanged();
//                SsDeleteAndroidOperatingSystemCommand.RaiseCanExecuteChanged();
//            }
//        }

//        public override void Dispose()
//        {
//            _androidOperatingSystemService.Dispose();
//            _windowService.Dispose();
//            _parameterService.Dispose();
//            _messageBoxService.Dispose();
//        }
//    }
//}