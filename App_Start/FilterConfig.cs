using System.Web;
using System.Web.Mvc;

namespace DAISY_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {

            // This is used for API ErrorHandling.......

            filters.Add(new HandleErrorAttribute());
        }
    }
}
