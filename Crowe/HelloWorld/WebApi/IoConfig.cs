using Autofac;
using Autofac.Integration.WebApi;
using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace WebApi
{
    public class IoConfig
    {
        public static void RegisterDependencies(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<MessageGenerator>().As<IMessageGenerator>();
            builder.RegisterType<ItemRemoval>().As<IItemRemoval>();
            //If it is a file we want to write into, we modify the implementation registration here
            builder.RegisterType<CustomValueDbWriter>().As<ICustomValueWriter>();

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}