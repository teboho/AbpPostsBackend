using System.Threading.Tasks;
using Abp.Application.Services;
using Boxfusion.Posts.Authorization.Accounts.Dto;

namespace Boxfusion.Posts.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
