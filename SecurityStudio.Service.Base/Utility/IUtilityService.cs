using System.Windows.Media.Imaging;
using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Utility
{
    public interface IUtilityService : IService
    {
        void StartFileOrFolderInWindows(string fileOrFolderAddress);
        void RunOnUiThread(Action action);
        BitmapImage GetBitmapImageFromBytes(byte[] bytes);
        bool IsValidNationalCode(string nationalCode);
    }
}