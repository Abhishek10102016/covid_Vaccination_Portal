using System.Web;
using System.Web.Mvc;

namespace MindRuby.Cowin.PresentationL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
