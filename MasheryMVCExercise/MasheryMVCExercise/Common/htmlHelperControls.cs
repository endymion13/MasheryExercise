using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace MasheryMVCExercise.Common
{
    //Here you can add new customs controls

    public static class htmlHelperControls
    {   

        /// <summary>
        /// Custom Text Box
        /// </summary>
        /// <typeparam name="HtmlHelper"></typeparam>
        /// <typeparam name="string"></typeparam>
        /// <typeparam name="string"></typeparam>
        /// <typeparam name="string"></typeparam>
        /// <typeparam name="string"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="dir"></param>
        /// <param name="classType"></param>
        /// <returns></returns>
        /// 
        public static IHtmlString dirButton(this HtmlHelper helper, string id, string value, string dir, string classType)
        {

            string htmlString = String.Format("<input type=\"submit\" id=\"{0}\" value=\"{1}\"  dir=\"{2}\" class=\"{3}\" />", id, value, dir, classType);
            return new HtmlString(htmlString);
        }

 
    }
}