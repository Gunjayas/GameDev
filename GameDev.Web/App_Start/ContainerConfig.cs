using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDev.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder(); //builds a container
            builder.RegisterControllers
        } 
    }
}