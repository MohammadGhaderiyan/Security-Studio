using System.Threading.Tasks;

namespace SecurityStudio.Base.Main.Tool
{
    public class Tool
    {
        public Tool(bool supportsWindows, bool supportsLinux)
        {
            SupportsWindows = supportsWindows;
            SupportsLinux = supportsLinux;
        }

        public bool SupportsWindows { get; }
        public bool SupportsLinux { get; }
        public string CommandName { get; set; }

        public virtual async Task<string> RunCommand(string arguments = null)
        {
            return await Task.FromResult<string>(null);
        }

        public virtual async Task<string> Help()
        {
            return await Task.FromResult<string>(null);
        }

        public virtual async Task<string> Version()
        {
            return await Task.FromResult<string>(null);
        }
    }
}