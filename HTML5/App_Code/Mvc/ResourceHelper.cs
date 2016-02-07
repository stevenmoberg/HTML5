using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public static class ResourceHelper
{
    public static IHtmlString RenderStyle(this HtmlHelper helper, string url)
    {
        url = string.Concat(url, "?ts=", DateTime.Now.Ticks);
        var html = string.Format("<link type='text/css' rel='stylesheet' href='{0}' />", url);
        return new HtmlString(html);
    }

    public static IHtmlString RenderScript(this HtmlHelper helper, string url)
    {
        url = string.Concat(url, "?ts=", DateTime.Now.Ticks);
        var html = string.Format("<script type='text/javascript' src='{0}'></script>", url);
        return new HtmlString(html);
    }
}
