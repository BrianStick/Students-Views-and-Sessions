﻿using System.Web;
using System.Web.Mvc;

namespace Views_and_Sessions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
