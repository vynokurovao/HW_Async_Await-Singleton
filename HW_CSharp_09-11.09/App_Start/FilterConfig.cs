using System.Web;
using System.Web.Mvc;

namespace HW_CSharp_09_11._09
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
