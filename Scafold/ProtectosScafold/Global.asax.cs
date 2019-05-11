﻿using Protectos.Application.AutoMapper;
using Protectos.Infra.Data.Context;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProtectosScafold
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
            Database.SetInitializer<ProtectosContext>(new DropCreateDatabaseIfModelChanges<ProtectosContext>());
        }

       

    }
}
