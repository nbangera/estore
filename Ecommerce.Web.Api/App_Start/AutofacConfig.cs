using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Ecommerce.Application.Catalog.Product.Services;
using Ecommerce.Persistence;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Ecommerce.Web.Api.App_Start
{
    public class AutofacConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Set the dependency resolver to be Autofac. 
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();
            var mediatrOpenTypes = new[]
           {
                typeof(IRequestHandler<,>),
                typeof(INotificationHandler<>),
            };

            var services = Assembly.Load("Ecommerce.Application");
            foreach (var mediatrOpenType in mediatrOpenTypes)
            {
                builder
                    .RegisterAssemblyTypes(services)
                    .AsClosedTypesOf(mediatrOpenType)
                    .AsImplementedInterfaces();
            }
            builder.RegisterAssemblyTypes(services).AsClosedTypesOf(typeof(IValidator<>))
            .InstancePerRequest();

            builder.RegisterType<ProductService>().As<IProductService>().InstancePerRequest();
            builder.RegisterType<ApplicationDbContext>().InstancePerRequest().WithParameter(new NamedParameter("nameOrConnectionString", "DBConnectionString"));


            //builder.Register(ctx =>
            //{
            //    //var address = ctx.Resolve<IServerAddressProvider>().GetServerAddress();
            //    return new ApplicationDbContext("abcd");
            //}).InstancePerRequest();


            builder.RegisterAssemblyTypes(services).As<Profile>();
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                foreach (var profile in context.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
            Container = builder.Build();

            return Container;
        }

    }
}