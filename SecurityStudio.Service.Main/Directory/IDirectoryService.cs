using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Directory
{
    public interface IDirectoryService : IService
    {
        string GetApplicationDataDirectoryAddress();
        string GetRandomDirectoryName();
        string CreateTempDirectory();
        bool IsDirectory(string path);
        string GetDirectoryOfFile(string fileAddress);
    }
}