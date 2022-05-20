namespace SecurityStudio.Base.Main.Tool
{
    public abstract class Tool
    {
        public Tool(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}