using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Window
{
    public interface IWindowService : IService
    {
        void ShowSsView<T>(ShowViewOption showViewOption = null) where T : SsView;
        void ShowSsView<T>(T ssView, ShowViewOption showViewOption = null) where T : SsView;
        void ShowDialogSsView<T>(ShowViewOption showViewOption = null) where T : SsView;
        void ShowDialogSsView<T>(T ssView, ShowViewOption showViewOption = null) where T : SsView;
        void Close<T>(T ssViewModel) where T : SsViewModel;
        string ShowOpenFileDialog(string filter);
        string ShowSaveFileDialog(string filter, string directoryAddress = null, string fileName = null);
        string ShowOpenFileDialog(params FileType[] fileTypes);
        string ShowSaveFileDialog(string directoryAddress = null, string fileName = null, params FileType[] fileTypes);
        string ShowChooseFolderFileDialog();
    }
}