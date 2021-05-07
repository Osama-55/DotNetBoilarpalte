using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPV5.EntityFrameworkCore;
using ABPV5.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABPV5.Web.Tests
{
    [DependsOn(
        typeof(ABPV5WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABPV5WebTestModule : AbpModule
    {
        public ABPV5WebTestModule(ABPV5EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPV5WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABPV5WebMvcModule).Assembly);
        }
    }
}