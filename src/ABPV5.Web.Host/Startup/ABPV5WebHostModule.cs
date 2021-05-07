using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPV5.Configuration;

namespace ABPV5.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPV5WebCoreModule))]
    public class ABPV5WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPV5WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPV5WebHostModule).GetAssembly());
        }
    }
}
