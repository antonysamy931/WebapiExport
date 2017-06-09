using System.Web;
using System.Web.Mvc;

namespace GoogleApiMobileValidator
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}