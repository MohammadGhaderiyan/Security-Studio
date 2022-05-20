using System.Threading.Tasks;
using SecurityStudio.Base.Main.Common;

namespace SecurityStudio.Base.Main.Tool
{
    public abstract class CommandTool : Tool
    {
        public CommandTool(string name, string commandName) : base(name)
        {
            Name = name;
            CommandName = commandName;
        }

        public string CommandName { get; set; }

        public abstract Task<Result<string>> GetHelp();
        public abstract Task<Result<string>> GetVersion();
    }
}