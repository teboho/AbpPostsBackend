using Abp.Application.Services;
using Boxfusion.Posts.MultiTenancy.Dto;

namespace Boxfusion.Posts.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

