using Autofac;
using Sample.Models;
using Sample.Models.Concrete;
using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterService();
        }
        public void RegisterService()
        {
            var builder = new ContainerBuilder();
            // builder.Register<UnitOfWork>( x => { var dbctxt = new SampleDbContext(); return new UnitOfWork(dbctxt); }).As<IUnitOfWork>();
            //builder.RegisterType<UnitOfWork>().As<UnitOfWork>();
            builder.Register<UnitOfWork>(x => { return new UnitOfWork(); }).As<UnitOfWork>();
                 var container = builder.Build();

            //container.Resolve<IUnitOfWork>().Complete();
        }

    }
}
