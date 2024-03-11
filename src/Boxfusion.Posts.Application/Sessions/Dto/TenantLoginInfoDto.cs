using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Boxfusion.Posts.MultiTenancy;

namespace Boxfusion.Posts.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
