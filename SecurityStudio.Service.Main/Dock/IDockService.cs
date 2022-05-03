using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Dock
{
    public interface IDockService : IService
    {
        void ShowSsView<T>() where T : SsView;
        void Close(SsViewModel ssViewModel);
    }
}