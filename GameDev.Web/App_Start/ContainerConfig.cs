using Autofac;
using Autofac.Integration.Mvc;
using GameDev.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDev.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder(); //builds a container
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryCompanyData>().As<ICompanyData>().SingleInstance();
            // autofac knows about the type Inmemory company data and knows to use it whenever someone asks for
            //Icompany data.Everytime we get a http request we want a new instance of Inmemory companydata

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //anywhere mvc5 inject dependancies our container will jump into action

        } 
    }
}