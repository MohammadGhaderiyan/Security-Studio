namespace SecurityStudio.Service.Base.Directory
{
    public class DirectoryService : IDirectoryService
    {
        public string GetApplicationDataDirectoryAddress()
        {
            var result = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "Security Studio");

            if (System.IO.Directory.Exists(result) == false)
                System.IO.Directory.CreateDirectory(result);

            return result;
        }

        public string GetRandomDirectoryName()
        {
            return Path.GetRandomFileName();
        }

        public string CreateTempDirectory()
        {
            string result = Path.Combine(GetApplicationDataDirectoryAddress(),
                Path.GetRandomFileName());
            System.IO.Directory.CreateDirectory(result);

            return result;
        }

        public bool IsDirectory(string path)
        {
            var fileAttributes = System.IO.File.GetAttributes(path);

            return fileAttributes.HasFlag(FileAttributes.Directory);
        }

        public string GetDirectoryOfFile(string fileAddress)
        {
            return new FileInfo(fileAddress).DirectoryName;
        }

        public void Dispose()
        {
        }
    }
}