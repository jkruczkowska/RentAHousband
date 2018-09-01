using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RentAHousband.Helpers
{
    public static class HelpMeHelper
    {
        public static MvcHtmlString HelpMe(this HtmlHelper helper, string id, string url, string alternative, object htmlAttribute)
        {
            var builder = new TagBuilder("img");
            builder.GenerateId(id);
            builder.MergeAttribute("src", url);
            builder.MergeAttribute("alt", alternative);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttribute));

            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}