using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Service.Main.MessageBox;
using SecurityStudio.Service.Main.Session;
using SecurityStudio.Service.Main.Window;

namespace SecurityStudio.Module.Main.Login.ViewModel
{
    public class SsLoginViewModel : SsViewModel
    {
        private readonly ISessionService _sessionService;
        private readonly IWindowService _windowService;
        private readonly IMessageBoxService _messageBoxService;

        public SsLoginViewModel(ISessionService sessionService, IWindowService windowService,
            IMessageBoxService messageBoxService)
        {
            _sessionService = sessionService;
            _windowService = windowService;
            _messageBoxService = messageBoxService;
        }

        public SsCommand SsLoginCommand { get; set; }
        public SsCommand SsCancelCommand { get; set; }
        public SsCommand SsShowSsAdminCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsLoginCommand = new SsCommand(SsLogin, CanSsLogin);
            SsCancelCommand = new SsCommand(SsCancel);
            SsShowSsAdminCommand = new SsCommand(SsShowSsAdmin);
        }

        private void SsLogin(object parameter)
        {
            _sessionService.SetUser(new User());
            _windowService.Close(this);
        }

        private void SsShowSsAdmin(object parameter)
        {
            _windowService.Close(this);
        }

        private bool CanSsLogin(object parameter)
        {
            return string.IsNullOrWhiteSpace(UserName) == false &&
                   string.IsNullOrWhiteSpace(Password) == false;
        }

        private void SsCancel(object parameter)
        {
            _windowService.Close(this);
        }

        protected override void PrepareVariables()
        {
            Title = "Log in";
        }

        protected override void FillData()
        {
        }


        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
                SsLoginCommand.CheckCanExecuteChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
                SsLoginCommand.CheckCanExecuteChanged();
            }
        }

        public override void Dispose()
        {
            _sessionService.Dispose();
            _windowService.Dispose();
            _messageBoxService.Dispose();
        }
    }
}