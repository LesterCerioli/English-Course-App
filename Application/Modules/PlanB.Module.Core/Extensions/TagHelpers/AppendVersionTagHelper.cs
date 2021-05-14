using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Module.Core.Extensions.TagHelpers
{
    public class AppendVersionTagHelper : TagHelper
    {
        private const string AppendVersionAttributeName = "simpl-append-version";
        private readonly IConfiguration _config;
        public AppendVersionTagHelper(IConfiguration config)
        {
            _config = config;
        }
        
        [HtmlAttributeName(AppendVersionAttributeName)]
        public bool AppendVersion { get; set; }
        
        public override int Order => int.MinValue;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll(AppendVersionAttributeName);

            if (!AppendVersion)
            {
                return;
            }

            if (output.Attributes.ContainsName("href"))
            {
                var href = output.Attributes["href"].Value.ToString();
                output.Attributes.SetAttribute("href", AppendVersionToUrl(href));
            }

            if (output.Attributes.ContainsName("src"))
            {
                var src = output.Attributes["src"].Value.ToString();
                output.Attributes.SetAttribute("src", AppendVersionToUrl(src));
            }
        }

        private string AppendVersionToUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return string.Empty;
            }

            var version = _config["Global.AssertVersion"];
            return url.Contains("?") ? $"{url}&v={version}" : $"{url}?v={version}";
        }
    }
}
