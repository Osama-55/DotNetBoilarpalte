using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPV5.Configuration.Dto;

namespace ABPV5.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPV5AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
