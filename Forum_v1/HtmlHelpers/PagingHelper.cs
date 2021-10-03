using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum_v1.Models;

namespace Forum_v1.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static HtmlString PageLinks(this IHtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {            
            TagBuilder result = new TagBuilder("div");

            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder a = new TagBuilder("a");

                a.MergeAttribute("href", pageUrl(i));

                a.InnerHtml.Append(i.ToString());

                if (i == pagingInfo.CurrentPage)
                {
                    a.AddCssClass("selected");

                    a.AddCssClass("btn-primary");
                }

                a.AddCssClass("btn btn-default");

                result.InnerHtml.AppendHtml(a);
            }

            var writer = new System.IO.StringWriter();

            result.WriteTo(writer, HtmlEncoder.Default);

            return new HtmlString(writer.ToString());
        }
    }
}
