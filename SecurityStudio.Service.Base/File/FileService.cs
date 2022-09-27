namespace SecurityStudio.Service.Base.File
{
    public class FileService : IFileService
    {
        private readonly string _applicationDataFolder;

        public FileService()
        {
            _applicationDataFolder = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "Security Studio");
        }

        public byte[] ReadFile(string fileAddress)
        {
            return System.IO.File.ReadAllBytes(fileAddress);
        }

        public string GetRandomFileName()
        {
            return Path.GetRandomFileName();
        }

        public string GetRandomFileName(string extension)
        {
            return $"{GetRandomFileName()}.{extension}";
        }

        public string CreateTempFile()
        {
            var result = Path.Combine(_applicationDataFolder, GetRandomFileName());
            System.IO.File.Create(result).Close();

            return result;
        }

        public string GetFileNameOfFile(string fileAddress)
        {
            return new FileInfo(fileAddress).Name;
        }

        public string GetDirectoryAddressOfFile(string fileAddress)
        {
            var directoryInfo = new FileInfo(fileAddress).Directory;
            if (directoryInfo != null)
                return directoryInfo.FullName;

            return null;
        }

        public bool IsFile(string fileAddress)
        {
            var fileAttributes = System.IO.File.GetAttributes(fileAddress);

            return fileAttributes.HasFlag(FileAttributes.Directory) == false;
        }

        public string CombinePaths(params string[] paths)
        {
            return Path.Combine(paths);
        }

        public void Dispose()
        {
        }
    }
}