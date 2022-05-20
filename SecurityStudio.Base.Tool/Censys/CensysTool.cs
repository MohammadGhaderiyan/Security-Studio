using System;

namespace SecurityStudio.Base.Tool.Censys
{
    public class CensysTool : Main.Tool.Tool
    {
        public CensysTool() : base("Censys")
        {
        }

        public string GetUri(string query)
        {
            var uriBuilder = new UriBuilder
            {
                Scheme = "https",
                Host = "search.censys.io",
                Path = "search",
                Query = query.Trim()
            };

            return uriBuilder.ToString();
        }
    }
}