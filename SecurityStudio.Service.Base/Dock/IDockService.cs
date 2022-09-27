using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Dock
{
    public interface IDockService : IService
    {
        void ShowSsView<T>() where T : SsView;
        void Close(SsViewModel ssViewModel);
    }
}