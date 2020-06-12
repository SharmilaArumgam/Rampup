using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginDB.CustomHelper
{
    public static class CustomHelpers
    {
       
        //using static method
        public static string CustomLabel(string target, string text)
        {
            return String.Format("<label for ='{0}'>{1}</label>", target, text);
        }

        //using extension methods
        public static IHtmlContent HelloWorldHTMLString(this IHtmlHelper htmlHelper)
        => new HtmlString("<strong>Hello World</strong>");
    }

}
