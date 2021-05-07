using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPV5.Authorization;

namespace ABPV5
{
    [DependsOn(
        typeof(ABPV5CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPV5ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPV5AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPV5ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
