using System.Web;
using System.Web.Mvc;

namespace LAb_mvc_prvat_nova
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
