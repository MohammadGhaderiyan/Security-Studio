using System;
using System.Text;

namespace SecurityStudio.Base.Tool.Shodan
{
    public class ShodanTool : Main.Tool.Tool
    {
        public ShodanTool() : base(true, true)
        {
            CommandName = "";
        }

        public string GetUri(string net, string host, string port, string application,
            string server, string country, string city, string custom)
        {
            var stringBuilder = new StringBuilder("query=");

            #region Check Space

            if (net.Contains(" "))
                net = $"\"{net}\"";

            if (host.Contains(" "))
                host = $"\"{host}\"";

            if (port.Contains(" "))
                port = $"\"{port}\"";

            if (application.Contains(" "))
                application = $"\"{application}\"";

            if (server.Contains(" "))
                server = $"\"{server}\"";

            if (country.Contains(" "))
                country = $"\"{country}\"";

            if (city.Contains(" "))
                city = $"\"{city}\"";

            #endregion


            if (string.IsNullOrWhiteSpace(net) == false)
                stringBuilder.Append($"net:{net} ");

            if (string.IsNullOrWhiteSpace(host) == false)
                stringBuilder.Append($"host:{host} ");

            if (string.IsNullOrWhiteSpace(port) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"port:{port} ");

            if (string.IsNullOrWhiteSpace(application) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"application:{application} ");

            if (string.IsNullOrWhiteSpace(server) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"server:{server} ");

            if (string.IsNullOrWhiteSpace(country) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"country:{country} ");

            if (string.IsNullOrWhiteSpace(city) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"city:{city} ");

            if (string.IsNullOrWhiteSpace(custom) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"{custom} ");

            var uriBuilder = new UriBuilder
            {
                Scheme = "https",
                Host = "shodan.io",
                Path = "search",
                Query = stringBuilder.ToString().Trim()
            };

            return uriBuilder.ToString();
        }
    }
}