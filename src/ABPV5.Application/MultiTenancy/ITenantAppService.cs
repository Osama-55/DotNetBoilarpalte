using Abp.Application.Services;
using ABPV5.MultiTenancy.Dto;

namespace ABPV5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

