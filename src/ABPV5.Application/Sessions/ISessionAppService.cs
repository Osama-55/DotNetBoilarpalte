using System.Threading.Tasks;
using Abp.Application.Services;
using ABPV5.Sessions.Dto;

namespace ABPV5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
