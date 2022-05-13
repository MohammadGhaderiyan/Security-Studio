using System;

namespace SecurityStudio.Base.Tool.GoogleDork
{
    public class GoogleDorkTool : Main.Tool.Tool
    {
        public GoogleDorkTool() : base(true, true)
        {
            CommandName = "";
        }

        public string GetUri(string site, string fileType, string inUrl, string inTitle)
        {
            UriBuilder p = new UriBuilder("schema", "host", 50, "pathValue", "Extravalue");
            return p.ToString();
        }
    }
}