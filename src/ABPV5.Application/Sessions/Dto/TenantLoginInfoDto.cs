using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPV5.MultiTenancy;

namespace ABPV5.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
