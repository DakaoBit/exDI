using System.Web;
using System.Web.Mvc;

namespace MvcDemo_V2_Decoupled
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
