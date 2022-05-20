using System;
using System.Text;

namespace SecurityStudio.Base.Tool.GoogleDork
{
    public class GoogleDorkTool : Main.Tool.Tool
    {
        public GoogleDorkTool() : base("Google Dork")
        {
        }

        public string GetUri(string keyword, string site, string fileType,
            string inUrl, string inTitle, string link, string cache, string custom)
        {
            var stringBuilder = new StringBuilder("q=");

            #region Check Space

            if (site != null && site.Contains(" "))
                site = $"\"{site}\"";

            if (fileType != null && fileType.Contains(" "))
                fileType = $"\"{fileType}\"";

            if (inUrl != null && inUrl.Contains(" "))
                inUrl = $"\"{inUrl}\"";

            if (inTitle != null && inTitle.Contains(" "))
                inTitle = $"\"{inTitle}\"";

            if (link != null && link.Contains(" "))
                link = $"\"{link}\"";

            if (cache != null && cache.Contains(" "))
                cache = $"\"{cache}\"";

            #endregion


            if (string.IsNullOrWhiteSpace(keyword) == false)
                stringBuilder.Append($"{keyword} ");

            if (string.IsNullOrWhiteSpace(site) == false)
                stringBuilder.Append($"site:{site} ");

            if (string.IsNullOrWhiteSpace(fileType) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"filetype:{fileType} ");

            if (string.IsNullOrWhiteSpace(inUrl) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"inurl:{inUrl} ");

            if (string.IsNullOrWhiteSpace(inTitle) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"intitle:{inTitle} ");

            if (string.IsNullOrWhiteSpace(link) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"link:{link} ");

            if (string.IsNullOrWhiteSpace(cache) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"cache:{cache} ");

            if (string.IsNullOrWhiteSpace(custom) == false)
                // ReSharper disable once StringLiteralTypo
                stringBuilder.Append($"{custom} ");

            var uriBuilder = new UriBuilder
            {
                Scheme = "https",
                Host = "google.com",
                Path = "search",
                Query = stringBuilder.ToString().Trim()
            };

            return uriBuilder.ToString();
        }
    }
}