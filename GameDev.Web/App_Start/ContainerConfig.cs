using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using GameDev.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GameDev.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder(); //builds a container
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlCompanyData>().As<ICompanyData>().InstancePerRequest(); 
            builder.RegisterType<GameDevDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //anywhere mvc5 inject dependancies our container will jump into action
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container) ;

        } 
    }
}