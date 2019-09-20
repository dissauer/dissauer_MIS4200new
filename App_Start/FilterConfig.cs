using System.Web;
using System.Web.Mvc;

namespace dissauer_MIS4800
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
