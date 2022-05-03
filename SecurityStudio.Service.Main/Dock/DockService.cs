using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Main.Tunnel;

namespace SecurityStudio.Service.Main.Dock
{
    public class DockService : IDockService
    {
        private readonly ITunnelService _tunnelService;

        public DockService(ITunnelService tunnelService)
        {
            _tunnelService = tunnelService;
        }

        public void ShowSsView<T>() where T : SsView
        {
            _tunnelService.Send("ShowDockMessage", new ShowDockMessage(typeof(T)));
        }

        public void Close(SsViewModel ssViewModel)
        {
            _tunnelService.Send("CloseDockMessage", new CloseDockMessage(ssViewModel.SsView));
        }

        public void Dispose()
        {
            _tunnelService?.Dispose();
        }
    }
}