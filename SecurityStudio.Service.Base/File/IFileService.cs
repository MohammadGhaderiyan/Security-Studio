using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.File
{
    public interface IFileService : IService
    {
        byte[] ReadFile(string fileAddress);
        string GetRandomFileName();
        string GetRandomFileName(string extension);
        string CreateTempFile();
        string GetFileNameOfFile(string fileAddress);
        string GetDirectoryAddressOfFile(string fileAddress);
        bool IsFile(string fileAddress);
        string CombinePaths(params string[] paths);
    }
}