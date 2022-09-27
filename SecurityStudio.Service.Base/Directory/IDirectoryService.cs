using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Directory
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