﻿using System.Web;
using System.Web.Mvc;

namespace RAD302_S00141926
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
