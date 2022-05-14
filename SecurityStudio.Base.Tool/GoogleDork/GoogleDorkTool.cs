﻿using System;
using System.Text;

namespace SecurityStudio.Base.Tool.GoogleDork
{
    public class GoogleDorkTool : Main.Tool.Tool
    {
        public GoogleDorkTool() : base(true, true)
        {
            CommandName = "";
        }

        public string GetUri(string keyword, string site, string fileType,
            string inUrl, string inTitle, string link, string cache)
        {
            var stringBuilder = new StringBuilder("q=");

            #region Check Space

            if (site.Contains(" "))
                site = $"\"{site}\"";

            if (fileType.Contains(" "))
                fileType = $"\"{fileType}\"";

            if (inUrl.Contains(" "))
                inUrl = $"\"{inUrl}\"";

            if (inTitle.Contains(" "))
                inTitle = $"\"{inTitle}\"";

            if (link.Contains(" "))
                link = $"\"{link}\"";

            if (cache.Contains(" "))
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