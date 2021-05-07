using System.Threading.Tasks;
using ABPV5.Configuration.Dto;

namespace ABPV5.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
