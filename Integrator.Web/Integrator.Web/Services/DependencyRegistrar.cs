using Autofac;
using Integrator.Common;
using Integrator.Common.Configuration;
using Integrator.Common.Events;
using Integrator.Common.Interfaces;
using Integrator.Data;
using Integrator.Data.Interfaces;
using Integrator.Factories.Users;
using Integrator.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrator.Web.Services
{
    public partial class DependencyRegistrar : IDependencyRegistrar
    {


        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, IntegratorConfig config)
        {
            //file provider
            builder.RegisterType<IntegratorFileProvider>().As<IIntegratorFileProvider>().InstancePerLifetimeScope();

            //web helper
            builder.RegisterType<WebHelper>().As<IWebHelper>().InstancePerLifetimeScope();


            //repositories
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();


            //services
            builder.RegisterType<UserRegistrationService>().As<IUserRegistrationService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            


            //Factories
            builder.RegisterType<UserViewModelFactory>().As<IUserViewModelFactory>().InstancePerLifetimeScope();

            
            builder.RegisterType<DbInitializer>().As<IDbInitializer>().SingleInstance();
            //Event publisher
            builder.RegisterType<EventPublisher>().As<IEventPublisher>().SingleInstance();
        }

        public int Order
        {
            get { return 0; }
        }
    }
}
