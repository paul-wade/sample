﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CoasterQuery.App_Start;
using System.Web.Http;

namespace CoasterQuery
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}