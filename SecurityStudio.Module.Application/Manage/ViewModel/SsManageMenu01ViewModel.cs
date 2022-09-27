using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Base.Container;
using SecurityStudio.Service.Base.Parameter;

namespace SecurityStudio.Module.Application.Manage.ViewModel
{
    public class SsManageMenu01ViewModel : SsViewModel
    {
        private readonly IContainerService _containerService;
        private readonly IParameterService _parameterService;

        public SsManageMenu01ViewModel(IContainerService containerService,
            IParameterService parameterService)
        {
            _containerService = containerService;
            _parameterService = parameterService;
        }

        protected override void PrepareSsCommands()
        {

        }

        protected override void PrepareVariables()
        {
            Title = "Menu 01";
        }

        private SsView _mainSsView;
        public SsView MainSsView
        {
            get => _mainSsView;
            set
            {
                _mainSsView = value;
                OnPropertyChanged();
            }
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
            _containerService.Dispose();
            _parameterService.Dispose();
        }
    }
}