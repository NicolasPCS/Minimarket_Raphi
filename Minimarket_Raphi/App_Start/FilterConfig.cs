﻿using System.Web;
using System.Web.Mvc;

namespace Minimarket_Raphi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
