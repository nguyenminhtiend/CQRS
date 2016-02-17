using System;
using Autofac;
using CQRS.Context;
using CQRS.Dispatchers;
using CQRS.Handlers;

namespace CQRS
{
    public class IocConfig
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<CqrsContext>().AsSelf().InstancePerRequest();

            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>();
            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AsClosedTypesOf(typeof(IQueryHandler<,>))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AsClosedTypesOf(typeof(ICommandHandler<,>))
                .AsImplementedInterfaces();
        }
    }
}
