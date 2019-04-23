using Autofac;
using Integrator.Common;
using Integrator.Common.Configuration;
using Integrator.Common.Events;
using Integrator.Common.Interfaces;
using Integrator.Data;
using Integrator.Data.Interfaces;
using Integrator.Factories.Administration;
using Integrator.Factories.CurriculumVitae;
using Integrator.Factories.KnowledgeBase.Core;
using Integrator.Factories.Users;
using Integrator.Models.ViewModels.Common;
using Integrator.Services.Common;
using Integrator.Services.Common.Files;
using Integrator.Services.Companies;
using Integrator.Services.CurriculumVitae;
using Integrator.Services.KnowledgeBase.Core;
using Integrator.Services.KnowledgeBase.Users;
using Integrator.Services.Users;

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

            //EntityProcessing Response
            builder.RegisterType<EntityCRUDResponse>().As<IEntityCRUDResponse>().InstancePerLifetimeScope();
            

            //repositories
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();


            //services
            builder.RegisterType<UserRegistrationService>().As<IUserRegistrationService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<UserKnowledgeBaseService>().As<IUserKnowledgeBaseService>().InstancePerLifetimeScope();
            builder.RegisterType<CurriculumVitaeService>().As<ICurriculumVitaeService>().InstancePerLifetimeScope();
            builder.RegisterType<EducationInstitutionService>().As<IEducationInstitutionService>().InstancePerLifetimeScope();
            builder.RegisterType<InterestService>().As<IInterestService>().InstancePerLifetimeScope();
            builder.RegisterType<LanguageService>().As<ILanguageService>().InstancePerLifetimeScope();
            builder.RegisterType<FileService>().As<IFileService>().InstancePerLifetimeScope();
            builder.RegisterType<QualificationService>().As<IQualificationService>().InstancePerLifetimeScope();
            builder.RegisterType<CoreKnowledgeBaseService>().As<ICoreKnowledgeBaseService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();
            




            //Factories
            builder.RegisterType<UserViewModelFactory>().As<IUserViewModelFactory>().InstancePerLifetimeScope();
            builder.RegisterType<CurriculumVitaeViewModelFactory>().As<ICurriculumVitaeViewModelFactory>().InstancePerLifetimeScope();
            builder.RegisterType<CurriculumVitaeViewModelFactory>().As<ICurriculumVitaeViewModelFactory>().InstancePerLifetimeScope();
            builder.RegisterType<AdministrationViewModelFactory>().As<IAdministrationViewModelFactory>().InstancePerLifetimeScope();
            builder.RegisterType<CoreKbSkillViewModelFactory>().As<ICoreKbSkillViewModelFactory>().InstancePerLifetimeScope();
            


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
