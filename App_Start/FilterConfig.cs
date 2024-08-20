using System.Web;
using System.Web.Mvc;

namespace Mvc_BusinessInformation_registerFm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
