using System.Web;
using System.Web.Mvc;

namespace mvc_cherry_pick
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
